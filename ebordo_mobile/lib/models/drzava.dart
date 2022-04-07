import 'dart:convert';

class Drzava {
  final int drzavaId;
  final String nazivDrzave;
  final List<int> zastava;

  Drzava(
      {required this.drzavaId,
      required this.nazivDrzave,
      required this.zastava});

  factory Drzava.fromJson(Map<String, dynamic> json) {
    String stringByte = json["zastava"] as String;
    List<int> bytes = base64.decode(stringByte);
    return Drzava(
      drzavaId: int.parse(json["drzavaId"].toString()),
      nazivDrzave: json["nazivDrzave"],
      zastava: bytes,
    );
  }

  Map<String, dynamic> toJson() =>
      {"drzavaId": drzavaId, "nazivDrzave": nazivDrzave, "zastava": zastava};
}
