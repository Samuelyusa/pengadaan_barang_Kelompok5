//$.ajax({
//    // contentType :"application/json",
//    url: "https://localhost:44308/api/Supplier",
//    type: "GET"
//    //data :JSON.stringify(o)
//}).done((result) => {
//    test = "";
//    $.each(result.data, function (key, val) {

//        test += ` <tr>
//                    <td>${val.id}</td>
//                    <td>${val.nama}</td>
//                    <td>${val.alamat}</td>
//                    <td>${val.email}</td>
//                    <td>${val.telepon}
//                                </td>

//                                        <td>${val.kota}
//                                </td>
//                                <td>
//                                    <button class="btn btn-success" data-toggle="modal" data-target="#edit" onclick="getbyid('${val.id}')">Edit</button>
//                                    <a type="button" class="btn btn-danger btn-sm" data-toggle="modal" data-target="#hapus">Delete</a></td>
//                            <!-- Modal Hapus Data -->
//                            <div class="modal fade" id="hapus" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
//                                <div class="modal-dialog">
//                                    <div class="modal-content">
//                                        <div class="modal-header">
//                                            <h5 class="modal-title" id="exampleModalLabel">Hapus Data Supplier</h5>

//                                            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
//                                                <span aria-hidden="true">&times;</span>
//                                            </button>
//                                        </div>
//                                        <form>
//                                            <div class="modal-body">
//                                                <p>Apakah anda yakin ingin menghapus data supplier ?</p>
//                                            </div>
//                                            <div class="modal-footer">
//                                                <button type="submit" class="btn btn-primary" asp-action="DeleteSupplier" asp-route-id="@item.Id">Yes</button>
//                                                <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
//                                            </div>
//                                </td>
//                            </tr>`;
//    })
//    $("#dataTable").html(test);
//}).fail((error) => {
//    console.log(error);
//})

$(document).ready(function () {
    let myTable = $('#MyTableSupplier').DataTable({
        ajax: {
            url: "https://localhost:44308/api/Supplier",
            dataSrc: "data",
            dataType: "JSON"
        },
        columns: [
            {
                data: "null",
                "render": function (data, type, row, meta) {
                    return meta.row + meta.settings._iDisplayStart + 1;
                }
            },
            {
                data: "nama"
            },
            {
                data: "alamat"
            },
            {
                data: "email"
            },
            {
                data: "telepon"
            },
            {
                data: "kota"
            },
            {
                data: "id",
                render: function (data, type, row) {
                    return `<button class="btn btn-primary" onclick="detail('${data}')" data-toggle="modal" data-target="#edit">Detail</button>
                            <button class="btn btn-success" data-toggle="modal" data-target="#edit" onclick="getbyid('${data}')">Edit</button>`;
                }
            },
        ],
    });
});


function Insert(event) {
    event.preventDefault();
    var obj = new Object;

    obj.id = 0;
    obj.nama = $("#Nama").val()
    obj.alamat = $("#Alamat").val()
    obj.kota = $("#Kota").val()
    obj.email = $("#Email").val()
    obj.telepon = $("#Telepon").val()
    $.ajax({
        contentType: "application/json",
        url: "https://localhost:44308/api/Supplier",
        type: "POST",
        data: JSON.stringify(obj)
    }).done((result) => {
        alert("Suppleir nerhasil ditambah");
        $('#MyTableSupplier').DataTable().ajax.reload();
    })

}

function getbyid(stringURL) {
    $.ajax({
        url: "https://localhost:44308/api/Supplier/"+ stringURL
    }).done((result) => {
        console.log(result);
        $("#IdUpdt").val(result.data.id)
        $("#NamaUpdt").val(result.data.nama)
        $("#AlamatUpdt").val(result.data.alamat)
        $("#KotaUpdt").val(result.data.kota)
        $("#TeleponUpdt").val(result.data.telepon)
        $("#EmailUpdt").val(result.data.email)

    }).fail((error) => {
        console.log(error);
    })
}

function update() {
    event.preventDefault();
    var obj = new Object();

    obj.id = parseInt($("#IdUpdt").val());
    obj.nama = $("#NamaUpdt").val();
    obj.alamat = $("#AlamatUpdt").val();
    obj.kota = $("#KotaUpdt").val();
    obj.email = $("#EmailUpdt").val();
    obj.telepon = parseInt($("#TeleponUpdt").val());
    $.ajax({
        contentType: "application/json",
        url: "https://localhost:44308/api/Supplier/" + obj.id,
        type: "PUT",
        data: JSON.stringify(obj)
    }).done((result) => {
        Swal.fire(
            'Good job!',
            'You clicked the button!',
            'success'
        )
        $('#MyTableSupplier').DataTable().ajax.reload();
    })

}



