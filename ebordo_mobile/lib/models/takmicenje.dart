import 'dart:convert';

class Takmicenje {
  final int takmicenjeId;
  final String nazivTakmicenja;
  final List<int> logo;

  Takmicenje(
      {required this.takmicenjeId,
      required this.nazivTakmicenja,
      required this.logo});

  factory Takmicenje.fromJson(Map<String, dynamic> json) {
    String stringByte = json["logo"] as String;
    List<int> bytes = base64.decode(stringByte);
    return Takmicenje(
      takmicenjeId: int.parse(json["takmicenjeId"].toString()),
      nazivTakmicenja: json["nazivTakmicenja"],
      logo: bytes,
    );
  }

  Map<String, dynamic> toJson() => {
        "takmicenjeId": takmicenjeId,
        "nazivTakmicenja": nazivTakmicenja,
        "logo": logo
      };
}
