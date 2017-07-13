function AreYouSure()
{
    if (confirm("Are you sure you want to delete?!") == true) {
        txt="ok";
    } else {
        txt = "You pressed Cancel!";
    }

}