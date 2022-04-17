import 'dart:convert';
import 'package:ebordo_mobile/models/grad.dart';

class Stadion {
  final int stadionId;
  final String nazivStadiona;
  final Grad lokacijaStadiona;
  final List<int> slikaStadiona;

  Stadion({
    required this.stadionId,
    required this.nazivStadiona,
    required this.lokacijaStadiona,
    required this.slikaStadiona,
  });

  factory Stadion.fromJson(Map<String, dynamic> json) {
    String stringByte = json["slikaStadiona"] as String;
    List<int> bytes = base64.decode(stringByte);
    return Stadion(
      stadionId: int.parse(json["stadionId"].toString()),
      nazivStadiona: json["nazivStadiona"],
      lokacijaStadiona: Grad.fromJson(json['lokacijaStadiona']),
      slikaStadiona: bytes,
    );
  }

  Map<String, dynamic> toJson() => {
        "stadionId": stadionId,
        "nazivStadiona": nazivStadiona,
        "lokacijaStadiona": lokacijaStadiona,
        "slikaStadiona": slikaStadiona
      };
}
