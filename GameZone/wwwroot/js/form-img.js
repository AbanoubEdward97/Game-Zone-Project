let ImageFileInput = document.getElementById("Cover"),
    ImageCover = document.getElementsByClassName("cover")[0];
ImageFileInput.onchange = function () {
    ImageCover.setAttribute("src", window.URL.createObjectURL(this.files[0]));
    ImageCover.classList.remove("d-none");

}