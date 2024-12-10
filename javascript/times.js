var time1;
var time2;

time1 = "Santos";

time2 = "Palmeiras";

if(time1 == "Santos" || time2 == "São Paulo" || time1 == "São Paulo" || time2 == "Santos") {
    console.log("Campeão Mundial");
}

if(time2 == "Palmeiras" || time1 == "Corinthians" || time2 == "Corinthians" || time1 == "Palmeiras") {
    console.log("Maiores torcidas");
}

if(time1 == "Corinthians" && time2 == "Palmeiras" || time1 == "Palmeiras" && time2 == "Corinthians") {
    console.log("Derby");
}