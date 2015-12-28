package siat.multimedia.algorithm;

import java.util.LinkedList;
import java.util.List;
import org.opencv.android.Utils;
import org.opencv.core.Mat;
import org.opencv.core.Rect;
import org.opencv.core.Size;
import siat.multimedia.network.NetworkClient;
import android.content.Context;
import android.graphics.Bitmap;

public class NetworkFaceAlgorithm extends FaceAlgorithmBase {
	private String strServerIpAddress = "192.168.1.100";

	public NetworkFaceAlgorithm(Context context) {
		super(context);
	}

	public Bitmap getCapturedBitmap(Mat rgba, Mat gray) {
		List<Rect> listFaces = null;
		if (mCascade != null) {
			int height = gray.rows();
			int faceSize = Math.round(height * minFacesize);
			listFaces = new LinkedList<Rect>();
			mCascade.detectMultiScale(gray, listFaces, 1.1, 2, 2, new Size(
					faceSize, faceSize));
		}
		Bitmap bmp = Bitmap.createBitmap(rgba.cols(), rgba.rows(),
				Bitmap.Config.ARGB_8888);
		if (Utils.matToBitmap(rgba, bmp)) {
			if (listFaces.size() > 0) {
				NetworkClient netClient = new NetworkClient(strServerIpAddress);
				netClient.sendPictureData(bmp);
				return bmp;
			}
		}
		bmp.recycle();
		return null;
	}
}
