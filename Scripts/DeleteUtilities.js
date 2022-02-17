
// submit form when clicking anchor
var idForm = "delForm";
var idButton = "delButton";
var idModalConfirmDelete = "confirmDeleteModal";

document.getElementById(idModalConfirmDelete).onclick = () => {
    document.getElementById(idForm).submit();
}