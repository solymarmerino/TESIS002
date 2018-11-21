function validarFormulario() {
    jQuery.validator.messages.required = 'Esta campo es obligatorio.';
    jQuery.validator.messages.number = 'Esta campo debe ser num&eacute;rico.';
    $("#IngresarPersonal").validate();
}

function validar() {
    var cad = document.getElementsByTagName("CedulaPersonal").value.trim();
    console.log(cad)
    var total = 0;
    var longitud = cad.length;
    var longcheck = longitud - 1;

    if (cad !== "" && longitud === 10) {
        for (i = 0; i < longcheck; i++) {
            if (i % 2 === 0) {
                var aux = cad.charAt(i) * 2;
                if (aux > 9) aux -= 9;
                total += aux;
            } else {
                total += parseInt(cad.charAt(i)); // parseInt o concatenará en lugar de sumar
            }
        }

        total = total % 10 ? 10 - total % 10 : 0;

        if (cad.charAt(longitud - 1) == total) {
            document.getElementById("salida").innerHTML = ("Cedula Válida");
            console.log("Cedula Válida");
        } else {
            document.getElementById("salida").innerHTML = ("Cedula Inválida");
            console.log("Cedula Inválida");
        }
    }
}

