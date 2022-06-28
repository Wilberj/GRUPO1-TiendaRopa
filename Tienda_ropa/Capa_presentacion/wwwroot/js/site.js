// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function modalFunction(DivModal) {
    if (DivModal.style.opacity == 0) {
        DivModal.style.transition = "all ease 1s";
        DivModal.style.opacity = 1;
        DivModal.style.pointerEvents = "all";
    } else {
        DivModal.style.transition = "all ease 1s";
        DivModal.style.opacity = 0;
        DivModal.style.pointerEvents = "none";
    }
}
