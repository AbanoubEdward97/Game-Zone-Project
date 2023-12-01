$("document").ready(function () {
    $(".delete-res").on("click", function () {
        var btn = $(this);
        console.log(btn.data("id"));

        const swalert = Swal.mixin({
            customClass: {
                confirmButton: "btn btn-danger mx-2",
                cancelButton: "btn btn-light",
            },
            buttonsStyling: false
        });
        swalert.fire({
            title: "Are you sure you want to delete this game?",
            text: "You won't be able to revert this!",
            icon: "warning",
            showCancelButton: true,
            confirmButtonText: "Yes, delete it!",
            cancelButtonText: "No, cancel!",
            reverseButtons: true
        }).then((result) => {
            console.log(result.isConfirmed)
            if (result.isConfirmed) {
                $.ajax({
                    url: `/Games/Delete/${btn.data("id")}`,
                    method: "DELETE",
                    success: function () {
                        swalert.fire({
                            title: "Deleted!",
                            text: "Your file has been deleted.",
                            icon: "success"
                        });
                        btn.parents("tr").fadeOut();
                    },
                    error: function () {
                        swalert.fire({
                            title: "Oops..!!",
                            text: "Something Went Wrong.",
                            icon: "error"
                        });
                    }
                })
                
            }
        });
    })
    
})
