const form = document.getElementById("loginForm");
const message = document.getElementById("message");
const loginSection = document.getElementById("loginSection");
const dashboardSection = document.getElementById("dashboardSection");
const welcomeMessage = document.getElementById("welcomeMessage");
const roleMessage = document.getElementById("roleMessage");

form.addEventListener("submit", handleLoginSubmit);

async function handleLoginSubmit(event) {
    event.preventDefault();

    clearMessage();

    const loginRequest = getLoginRequest();

    try {
        const user = await authenticateUser(loginRequest);
        showDashboard(user);
    } catch (error) {
        showError(error.message);
    }
}

function getLoginRequest() {
    const email = document.getElementById("email").value.trim();
    const password = document.getElementById("password").value;

    return {
        email,
        password
    };
}

async function authenticateUser(loginRequest) {
    const response = await fetch(
        "http://localhost:5267/api/authentication/login",
        {
            method: "POST",
            headers: {
                "Content-Type": "application/json"
            },
            body: JSON.stringify(loginRequest)
        }
    );

    if (response.status === 401) {
        throw new Error("Correo o contraseña incorrectos.");
    }

    if (!response.ok) {
        throw new Error("No fue posible iniciar sesión.");
    }

    return await response.json();
}

function showDashboard(user) {
    loginSection.hidden = true;
    dashboardSection.hidden = false;

    welcomeMessage.textContent = `Bienvenido, ${user.fullName}`;
    roleMessage.textContent = `Rol: ${getRoleName(user.role)}`;
}

function showError(errorMessage) {
    message.textContent = errorMessage;
}

function clearMessage() {
    message.textContent = "";
}

function getRoleName(role) {
    switch (role) {
        case 0:
            return "Administrador";
        case 1:
            return "Recepcionista";
        default:
            return "Desconocido";
    }
}