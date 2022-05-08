// public int treningID { get; set; }
// public DateTime datumOdrzavanja { get; set; }
// public string satnica { get; set; }
// public string lokacija { get; set; }
// public string fokusTreninga { get; set; }
// public bool isOdradjen { get; set; }
// public Trener zabiljezio { get; set; }
// public int zabiljezioID { get; set; }
// public int trajanje { get; set; }
import 'package:ebordo_mobile/models/trener.dart';

class Trening {
  final int treningID;
  final String datumOdrzavanja;
  final String satnica;
  final String lokacija;
  final String fokusTreninga;
  final bool isOdradjen;
  final Trener zabiljezio;
  final int trajanje;

  Trening({
    required this.treningID,
    required this.datumOdrzavanja,
    required this.satnica,
    required this.lokacija,
    required this.fokusTreninga,
    required this.isOdradjen,
    required this.zabiljezio,
    required this.trajanje,
  });

  factory Trening.fromJson(Map<String, dynamic> json) {
    return Trening(
      treningID: json["treningID"],
      datumOdrzavanja: json["datumOdrzavanja"],
      satnica: json["satnica"],
      lokacija: json["lokacija"],
      fokusTreninga: json["fokusTreninga"],
      isOdradjen: json["isOdradjen"],
      zabiljezio: Trener.fromJson(json['zabiljezio']),
      trajanje: json["trajanje"],
    );
  }

  Map<String, dynamic> toJson() => {
        "treningID": treningID,
        "datumOdrzavanja": datumOdrzavanja,
        "satnica": satnica,
        "lokacija": lokacija,
        "fokusTreninga": fokusTreninga,
        "isOdradjen": isOdradjen,
        "zabiljezio": zabiljezio,
        "trajanje": trajanje,
      };
}
