package siat.multimedia.view;

import org.opencv.android.Utils;
import org.opencv.core.Mat;
import org.opencv.core.CvType;
import org.opencv.core.Size;
import org.opencv.imgproc.Imgproc;
import siat.multimedia.algorithm.*;
import android.content.Context;
import android.graphics.Bitmap;
import android.graphics.Canvas;
import android.view.SurfaceHolder;

public class GraphicsView extends GraphicsViewBase {
	private Mat mYuv;
	private Mat mRgba;
	private Mat mGraySubmat;
	private Mat mIntermediateMat;
	private IGetBitmapInterface algorithm;

	public GraphicsView(Context context) {
		super(context);
		algorithm = new NetworkFaceAlgorithm(context);
	}

	@Override
	public void surfaceChanged(SurfaceHolder _holder, int format, int width,
			int height) {
		super.surfaceChanged(_holder, format, width, height);
		synchronized (this) {
			// initialize Mats before usage
			mYuv = new Mat(
					(this.getmMinimumHeight() + getmMinimumHeight() / 2),
					this.getmMinimumWidth(), CvType.CV_8UC1);
			mGraySubmat = mYuv.submat(0, getmMinimumHeight(), 0,
					this.getmMinimumWidth());
			mRgba = new Mat();
			mIntermediateMat = new Mat();
		}
	}

	@Override
	public void onDraw(Canvas canvas) {
		super.onDraw(canvas);
		/* ��mSCBitmap��ʾ����Ļ�� */
	}

	@Override
	protected Bitmap processFrame(byte[] data) {
		mYuv.put(0, 0, data);
		switch (AndroidTerminal.viewMode) {
		case AndroidTerminal.VIEW_MODE_GRAY:
			Imgproc.cvtColor(mGraySubmat, mRgba, Imgproc.COLOR_GRAY2RGBA, 4);
			break;
		case AndroidTerminal.VIEW_MODE_RGBA:
			Imgproc.cvtColor(mYuv, mRgba, Imgproc.COLOR_YUV420sp2RGB, 4);
			break;
		case AndroidTerminal.VIEW_MODE_CANNY:
			Imgproc.Canny(mGraySubmat, mIntermediateMat, 80, 100);
			Imgproc.cvtColor(mIntermediateMat, mRgba, Imgproc.COLOR_GRAY2BGRA,
					4);
			break;
		case AndroidTerminal.View_MODE_DETECT:
			Imgproc.cvtColor(mYuv, mRgba, Imgproc.COLOR_YUV420sp2RGB, 4);
			algorithm.getCapturedBitmap(mRgba, mGraySubmat);
		}
		Mat newRgba = new Mat();
		Size s = new Size();
		s.height = this.getFrameHeight();
		s.width = this.getFrameWidth();
		Imgproc.resize(mRgba, newRgba, s);
		Bitmap bmp = Bitmap.createBitmap(getFrameWidth(), getFrameHeight(),
				Bitmap.Config.ARGB_8888);
		if (Utils.matToBitmap(newRgba, bmp)) {
			return bmp;
		}

		bmp.recycle();
		return null;
	}

	@Override
	public void run() {
		super.run();

		synchronized (this) {
			// Explicitly deallocate Mats
			if (mYuv != null)
				mYuv.release();
			if (mRgba != null)
				mRgba.release();
			if (mGraySubmat != null)
				mGraySubmat.release();
			if (mIntermediateMat != null)
				mIntermediateMat.release();

			mYuv = null;
			mRgba = null;
			mGraySubmat = null;
			mIntermediateMat = null;
		}
	}
}
