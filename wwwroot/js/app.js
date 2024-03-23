function llenarFecha(){
    let valor = document.getElementById('fecha').value;
    console.log("eso");
    let fecha = new Date(valor);
    fecha.setDate(fecha.getDate() + 16)
    console.log(valor);
    let FechaFin = (parseInt(fecha.getMonth()) + 1) + '/' + fecha.getDate() + '/' + fecha.getFullYear();
    console.log(FechaFin);
    document.getElementById('fechaFin').value = FechaFin;
}