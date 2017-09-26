// Write your Javascript code.

// Função para alertar uma notificação.
function Alerta(message, title, type) {

    if (title == '') {
        title = 'Atenção';
    }

    var color = '';

    switch (type) {
        case 'Error':
            color = '#ff5343';
            break;
        case 'error':
            color = '#ff5343';
            break;
        case 'Warning':
            color = '#f15037';
            break;
        case 'warning':
            color = '#f15037';
            break;
        case 'Info':
            color = '#49958e';
            break;
        case 'info':
            color = '#49958e';
            break;
        case 'Success':
            color = '#f15037';
            break;
        case 'success':
            color = '#00c292';
            break;
        default:
            color = '#00c292';
    }

    $.toast({
        heading: title,
        text: text,
        position: 'top-right',
        loaderBg: color,
        icon: 'info',
        hideAfter: 3000,
        stack: 6
    });
}