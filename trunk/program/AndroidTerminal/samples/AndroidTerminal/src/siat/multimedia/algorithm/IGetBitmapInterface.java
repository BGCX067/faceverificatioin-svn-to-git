package siat.multimedia.algorithm;

import org.opencv.core.Mat;

import android.graphics.Bitmap;

public interface IGetBitmapInterface {

	public abstract Bitmap getCapturedBitmap(Mat rgba, Mat gray);

}