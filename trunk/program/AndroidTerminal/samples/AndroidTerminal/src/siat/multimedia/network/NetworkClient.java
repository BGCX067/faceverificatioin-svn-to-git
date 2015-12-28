package siat.multimedia.network;

import java.io.BufferedOutputStream;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.IOException;
import java.io.OutputStream;
import java.net.Socket;
import java.net.UnknownHostException;

import android.graphics.Bitmap;
import android.util.Log;

public class NetworkClient {
	private String strServerIpAddress;
	private Socket serverSocket;
	private BufferedOutputStream bosStreamWriter;

	public BufferedOutputStream getBosStreamWriter() {
		return bosStreamWriter;
	}

	public void setBosStreamWriter(BufferedOutputStream writer) {
		this.bosStreamWriter = writer;
	}

	public NetworkClient(String strServerAddress) {
		this.strServerIpAddress = strServerAddress;
		try {
			serverSocket = new Socket(strServerIpAddress, 4702);
		} catch (UnknownHostException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}

	public void sendPictureData(Bitmap bmp) {
		try {
			bosStreamWriter = new BufferedOutputStream(
					serverSocket.getOutputStream());
			bmp.compress(Bitmap.CompressFormat.JPEG, 100, bosStreamWriter);
			bosStreamWriter.flush();
			bosStreamWriter.close();
		} catch (UnknownHostException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
}
