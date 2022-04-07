import 'dart:convert';
import 'package:http/http.dart' as http;
import 'dart:io';
import '../models/korisnik.dart';

class APIService {
  static Korisnik? logovaniKorisnik;
  static String username = "";
  static String password = "";
  String route;

  APIService({required this.route});

  static void PostaviKredencijale(String Username, String Password) {
    username = "haris.pandzic@fksarajevo.ba";
    password = "Test1234!";
  }

  static void PostaviLogovanogKorisnika(var result) {
    logovaniKorisnik = result;
  }

  static Future Auth() async {
    String baseUrl = "http://127.0.0.1:58250/api/Korisnik/Auth";
    final String basicAuth =
        'Basic ' + base64Encode(utf8.encode('$username:$password'));
    final response = await http.get(
      Uri.parse(baseUrl),
      headers: {HttpHeaders.authorizationHeader: basicAuth},
    );
    if (response.statusCode == 200) {
      return json.decode(response.body);
    }
    return null;
  }

  static Future<List<dynamic>?> Get(String route, dynamic object) async {
    String queryString = Uri(queryParameters: object).query;
    String baseUrl = "http://127.0.0.1:58250/api/" + route;
    if (object != null) {
      baseUrl = baseUrl + '?' + queryString;
    }

    final String basicAuth =
        'Basic ' + base64Encode(utf8.encode('$username:$password'));
    final response = await http.get(
      Uri.parse(baseUrl),
      headers: {HttpHeaders.authorizationHeader: basicAuth},
    );
    if (response.statusCode == 200) {
      return json.decode(response.body) as List;
    }
    return null;
  }
}
