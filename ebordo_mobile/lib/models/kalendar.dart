class KalendarEvent {
  final String opis;
  final String datum;
  final String satnica;
  final String trajanje;
  final String lokacija;
  final String tipEventa;

  KalendarEvent({
    required this.opis,
    required this.datum,
    required this.satnica,
    required this.trajanje,
    required this.lokacija,
    required this.tipEventa,
  });

  factory KalendarEvent.fromJson(Map<String, dynamic> json) {
    return KalendarEvent(
      opis: json["opis"],
      datum: json["datum"],
      satnica: json["satnica"],
      trajanje: json["trajanje"],
      lokacija: json["lokacija"],
      tipEventa: json["tipEventa"],
    );
  }
}
