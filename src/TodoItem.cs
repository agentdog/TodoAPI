class TodoItem {
	public string todoname {get; set;}
	public bool completed {get; set;}

	public TodoItem (string TodoName, bool isCompleted = false) {
		todoname = TodoName;
		completed = isCompleted;
	}
}