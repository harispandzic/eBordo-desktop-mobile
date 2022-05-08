// public int notifikacijaId { get; set; }
// public int korisnikId { get; set; }
// public string tekstNotifikacije { get; set; }
// public DateTime datumNotifikacije { get; set; }
// public string tipNotifikacije { get; set; }

class Notifikacija {
  final int notifikacijaId;
  final int korisnikId;
  final String tekstNotifikacije;
  final String datumNotifikacije;
  final String tipNotifikacije;

  Notifikacija({
    required this.notifikacijaId,
    required this.korisnikId,
    required this.tekstNotifikacije,
    required this.datumNotifikacije,
    required this.tipNotifikacije,
  });

  factory Notifikacija.fromJson(Map<String, dynamic> json) {
    return Notifikacija(
      notifikacijaId: int.parse(json["notifikacijaId"].toString()),
      korisnikId: json["korisnikId"],
      tekstNotifikacije: json["tekstNotifikacije"],
      datumNotifikacije: json["datumNotifikacije"],
      tipNotifikacije: json["tipNotifikacije"],
    );
  }

  Map<String, dynamic> toJson() => {
        "notifikacijaId": notifikacijaId,
        "korisnikId": korisnikId,
        "tekstNotifikacije": tekstNotifikacije,
        "datumNotifikacije": datumNotifikacije,
        "tipNotifikacije": tipNotifikacije,
      };
}
