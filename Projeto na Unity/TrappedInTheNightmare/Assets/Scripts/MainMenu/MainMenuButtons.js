import UnityEngine.SceneManagement;

function PlayGame(){
	SceneManager.LoadScene(1);
};

function QuitGame(){
	Application.Quit();
};

function ReturnToHome(){
	SceneManager.LoadScene(0);	
};