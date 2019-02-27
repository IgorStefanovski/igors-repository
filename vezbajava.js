document.getElementById("klik")
addEventListener("click", function () {
    let request = new XMLHttpRequest()
    request.onload = function () {
        xhr.onload = function () {
            console.log("Request is sent!");
            if (request.status >= 200 && request.status < 300) {
                               
            } else {

                console.log(request.responseText)
                
            }



        }







