function addGuestMessage(interaction) {
    // Crear el elemento div
    var divElement = document.createElement("div");
    divElement.className = "media media-chat";

    // Crear la etiqueta de imagen
    var imgElement = document.createElement("img");
    imgElement.className = "avatar";
    imgElement.src = "https://img.icons8.com/color/36/000000/administrator-male.png";
    imgElement.alt = "...";

    // Crear el elemento div para el cuerpo del chat
    var mediaBodyElement = document.createElement("div");
    mediaBodyElement.className = "media-body";

    // Crear el párrafo de texto
    var textElement = document.createElement("p");
    textElement.textContent = interaction.Message;

    // Crear el elemento de metadatos
    var metaElement = document.createElement("p");
    metaElement.className = "meta";
    metaElement.textContent = interaction.User;

    // Agregar los elementos en la jerarquía correcta
    mediaBodyElement.appendChild(textElement);
    mediaBodyElement.appendChild(metaElement);
    divElement.appendChild(imgElement);
    divElement.appendChild(mediaBodyElement);

    // Obtener el contenedor existente
    var chatContent = document.getElementById("chat-content");

    // Agregar el nuevo fragmento HTML al contenedor
    chatContent.appendChild(divElement);
}

function addHostMessage(interaction) {
    // Crear el elemento div
    var divElement = document.createElement("div");
    divElement.className = "media media-chat media-chat-reverse";

    // Crear el elemento div para el cuerpo del chat
    var mediaBodyElement = document.createElement("div");
    mediaBodyElement.className = "media-body";

    // Crear el párrafo de texto
    var textElement = document.createElement("p");
    textElement.textContent = interaction.Message;

    // Crear el elemento de metadatos
    var metaElement = document.createElement("p");
    metaElement.className = "meta";

    // Agregar los elementos en la jerarquía correcta
    mediaBodyElement.appendChild(textElement);
    mediaBodyElement.appendChild(metaElement);
    divElement.appendChild(mediaBodyElement);

    // Obtener el contenedor existente
    var chatContent = document.getElementById("chat-content");

    // Agregar el nuevo fragmento HTML al contenedor
    chatContent.appendChild(divElement);
}

function clearChat() {
    // Obtener el contenedor existente
    var chatContent = document.getElementById("chat-content");

    // Eliminar todos los elementos dentro del contenedor
    chatContent.innerHTML = "";
    console.log('Clear chat');
}