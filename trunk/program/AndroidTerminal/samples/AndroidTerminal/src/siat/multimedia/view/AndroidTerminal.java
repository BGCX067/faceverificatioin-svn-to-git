package siat.multimedia.view;
import android.app.Activity;
import android.os.Bundle;
import android.util.Log;
import android.view.Menu;
import android.view.MenuItem;
import android.view.Window;
import android.widget.LinearLayout;

public class AndroidTerminal extends Activity {
	private static final String TAG = "Sample::Activity";
	public static final int VIEW_MODE_RGBA = 0;
	public static final int VIEW_MODE_GRAY = 1;
	public static final int VIEW_MODE_CANNY = 2;
	public static final int View_MODE_DETECT = 3;
	private MenuItem mItemPreviewRGBA;
	private MenuItem mItemPreviewGray;
	private MenuItem mItemPreviewCanny;
	private MenuItem mItemPreviewDetection;
	public static int viewMode = VIEW_MODE_RGBA;
	private GraphicsView gvView;

	public AndroidTerminal() {
		Log.i(TAG, "Instantiated new " + this.getClass());
	}

	/** Called when the activity is first created. */
	@Override
	public void onCreate(Bundle savedInstanceState) {
		Log.i(TAG, "onCreate");
		super.onCreate(savedInstanceState);
		requestWindowFeature(Window.FEATURE_NO_TITLE);
		gvView = new GraphicsView(this);
		setContentView(R.layout.main);
		LinearLayout layout = (LinearLayout) findViewById(R.id.linearlayout);
		layout.addView(gvView);
	}

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		Log.i(TAG, "onCreateOptionsMenu");
		mItemPreviewRGBA = menu.add("Preview RGBA");
		mItemPreviewGray = menu.add("Preview GRAY");
		mItemPreviewCanny = menu.add("Canny");
		mItemPreviewDetection = menu.add("Facedetection");
		return true;
	}

	@Override
	public boolean onOptionsItemSelected(MenuItem item) {
		Log.i(TAG, "Menu Item selected " + item);
		if (item == mItemPreviewRGBA)
			viewMode = VIEW_MODE_RGBA;
		else if (item == mItemPreviewGray)
			viewMode = VIEW_MODE_GRAY;
		else if (item == mItemPreviewCanny)
			viewMode = VIEW_MODE_CANNY;
		else if (item == mItemPreviewDetection)
			viewMode = View_MODE_DETECT;
		return true;
	}
}
