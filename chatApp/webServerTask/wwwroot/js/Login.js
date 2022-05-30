function validateLogin() {
    //collect login data in JavaScript variables  
    let name = document.getElementById("name").value;
    let password = document.getElementById("password").value;

    // Checks that the Username field is not empty
    if (name.length == 0) {
        alert("Please enter a Username.");
        // Checks that the password field is not empty  
    } else if (password.length == 0) {
        alert("Please enter a password.");
        // Checks that such a Username exists in the system
    } else if (!(checkUsername(contactsList, name))) {
        alert("Username or password are incorrect.");
        // If such a Username exists in the system, 
        // checks that the password matches the Username
    } else if (checkUsername(contactsList, name)) {
        for (let contact of contactsList) {
            if (contact.Username === name) {
                if (password !== contact.Password) {
                    alert("Username or password are incorrect.");
                }
                // If the login is valid
                else {
                    //document.write("Login successfully");
                    //break; 
                    var nickname = "";
                    event.preventDefault();
                    // take the user details to create his photo and nickname
                    for (let c of contactsList) {
                        if (c.Username === name) {
                            nickname = c.Nickname;
                        }
                    }

                    // save the realNmae
                    localStorage.setItem("n", name);

                    // adding nickname in the app screen chat
                    localStorage.setItem("nick", nickname);

                    window.location.href = "ChatAfterLogin";
                }
            }
        }
    }
}