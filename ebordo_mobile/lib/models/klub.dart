import 'dart:convert';
import 'package:ebordo_mobile/models/stadion.dart';
import 'grad.dart';

class Klub {
  final int klubId;
  final String nazivKluba;
  final Grad grad;
  final Stadion stadion;
  final List<int> grb;

  Klub({
    required this.klubId,
    required this.nazivKluba,
    required this.grad,
    required this.stadion,
    required this.grb,
  });

  factory Klub.fromJson(Map<String, dynamic> json) {
    String stringByte = json["grb"] as String;
    List<int> bytes = base64.decode(stringByte);
    return Klub(
      klubId: int.parse(json["klubId"].toString()),
      nazivKluba: json["nazivKluba"],
      grad: Grad.fromJson(json['grad']),
      stadion: Stadion.fromJson(json['stadion']),
      grb: bytes,
    );
  }

  Map<String, dynamic> toJson() => {
        "klubId": klubId,
        "nazivKluba": nazivKluba,
        "grad": grad,
        "stadion": stadion,
        "grb": grb
      };
}
