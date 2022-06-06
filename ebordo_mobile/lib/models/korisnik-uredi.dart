class KorisnikUredi {
  final String adresa;
  final String telefon;
  final String email;
  final bool isAktivan;

  KorisnikUredi({
    required this.adresa,
    required this.telefon,
    required this.email,
    required this.isAktivan,
  });

  factory KorisnikUredi.fromJson(Map<String, dynamic> json) {
    return KorisnikUredi(
      adresa: json["adresa"],
      telefon: json["telefon"],
      email: json["email"],
      isAktivan: json["isAktivan"],
    );
  }

  Map<String, dynamic> toJson() => {
        "adresa": adresa,
        "telefon": telefon,
        "email": email,
        "isAktivan": isAktivan
      };
}
