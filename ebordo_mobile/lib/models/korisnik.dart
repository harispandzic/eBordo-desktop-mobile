import 'dart:convert';
import 'drzava.dart';

class Korisnik {
  final int korisnikId;
  final String ime;
  final String prezime;
  final String datumRodjenja;
  final String korisnickoIme;
  final Drzava drzavljanstvo;
  final bool isIgrac;
  final bool isTrener;
  final bool isAdmin;
  final bool isAktivan;
  final List<int> slika;

  Korisnik(
      {required this.korisnikId,
      required this.ime,
      required this.prezime,
      required this.datumRodjenja,
      required this.korisnickoIme,
      required this.drzavljanstvo,
      required this.isIgrac,
      required this.isTrener,
      required this.isAdmin,
      required this.isAktivan,
      required this.slika});

  factory Korisnik.fromJson(Map<String, dynamic> json) {
    String stringByte = json["slika"] as String;
    List<int> bytes = base64.decode(stringByte);
    return Korisnik(
        korisnikId: int.parse(json["korisnikId"].toString()),
        ime: json["ime"],
        prezime: json["prezime"],
        datumRodjenja: json["datumRodjenja"],
        korisnickoIme: json["korisnickoIme"],
        drzavljanstvo: Drzava.fromJson(json['drzavljanstvo']),
        isIgrac: json["isIgrac"],
        isTrener: json["isTrener"],
        isAdmin: json["isAdmin"],
        isAktivan: json["isAktivan"],
        slika: bytes);
  }

  Map<String, dynamic> toJson() => {
        "korisnikId": korisnikId,
        "ime": ime,
        "prezime": prezime,
        "datumRodjenja": datumRodjenja,
        "korisnickoIme": korisnickoIme,
        "drzavljanstvo": drzavljanstvo,
        "isIgrac": isIgrac,
        "isTrener": isTrener,
        "isAdmin": isAdmin,
        "isAktivan": isAktivan,
        "slika": slika
      };
}
