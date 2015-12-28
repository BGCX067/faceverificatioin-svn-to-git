package siat.multimedia.algorithm;

import java.io.File;
import java.io.FileOutputStream;
import java.io.InputStream;
import org.opencv.R;
import org.opencv.core.Mat;
import org.opencv.objdetect.CascadeClassifier;

import android.content.Context;
import android.graphics.Bitmap;
import android.util.Log;
import android.view.SurfaceView;

public class FaceAlgorithmBase extends SurfaceView implements IGetBitmapInterface {
	private static final String TAG = "Sample::Algorithm";
	protected CascadeClassifier mCascade;
	protected static float minFacesize = 0.5f;

	public FaceAlgorithmBase(Context context) {
		super(context);
		loadClassifier(context, R.raw.haarcascade_frontalface_alt2);
	}

	protected boolean loadClassifier(Context context, int classifierResourceId) {
		try {
			InputStream is = context.getResources().openRawResource(
					classifierResourceId);
			File cascadeDir = context.getDir("cascade", Context.MODE_PRIVATE);
			File cascadeFile = new File(cascadeDir,
					"lbpcascade_frontalface2.xml");
			FileOutputStream os = new FileOutputStream(cascadeFile);
			byte[] buffer = new byte[4096];
			int bytesRead;
			while ((bytesRead = is.read(buffer)) != -1) {
				os.write(buffer, 0, bytesRead);
			}
			is.close();
			os.close();
			mCascade = new CascadeClassifier(cascadeFile.getAbsolutePath());
			if (mCascade.empty()) {
				Log.e(TAG, "Failed to load cascade classifier");
				mCascade = null;
			} else
				Log.i(TAG,
						"Loaded cascade classifier from "
								+ cascadeFile.getAbsolutePath());
			cascadeFile.delete();
			cascadeDir.delete();
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
			return false;
		}
		return true;
	}

	public Bitmap getCapturedBitmap(Mat rgba, Mat gray) {
		// TODO Auto-generated method stub
		return null;
	}
}
