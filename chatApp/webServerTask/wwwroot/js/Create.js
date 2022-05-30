// Validations on Username and password

// Return true if 'user' is already used by another user
function checkUsername(list, user) {
    const found = list.some(element => element.Username === user);
    if (found) {
        return true;
    }
    return false;
}

function validateForm() {
    //collect form data in JavaScript variables  
    let name = document.getElementById("name").value;
    let nickname = document.getElementById("nickname").value;
    let password = document.getElementById("password").value;
    let confirmPassword = document.getElementById("confirm-password").value;

    // Checks that the Username field is not empty
    if (name.length == 0) {
        alert("Username can't be empty.");
        // Checks that the nickname field is not empty  
    } else if (nickname.length == 0) {
        alert("Nickname can't be empty.");
        // Checks that the password field is not empty  
    } else if (password.length == 0) {
        alert("Password can't be empty.");
        // Checks that the password verification field is not empty
    } else if (confirmPassword.length == 0) {
        alert("You must verify the password.");
        // Checks that the password is at least 8 characters long
    } else if (password.length < 8) {
        alert("Password length must be at least 8 characters.");
        // Checks that the password contains at least one letter
    } else if (password.search(/[a-z]/i) < 0) {
        alert("Password must contain at least one letter in English.");
        // Checks that the password contains at least one digit
    } else if (password.search(/[0-9]/) < 0) {
        alert("Password must contain at least one digit.");
        // Checks that password verification is the same as password
    } else if (password !== confirmPassword) {
        alert("The password does not match.");
        // Checks that the Username is not used by another user
    } else if (checkUsername(contactsList, name)) {
        alert("Username already exists.")
        // If the user has registered successfully, 
        // update his details in the contacts list
    } else {
            contactsList.push({
                Username: name, Nickname: nickname,
                Password: password
            });
        
        // adding details in the app screen chat
        localStorage.setItem("name", name);
        localStorage.setItem("nickname", nickname);
        localStorage.setItem("password", password);

        window.location.href = "ChatAfterRegister";
    }
}