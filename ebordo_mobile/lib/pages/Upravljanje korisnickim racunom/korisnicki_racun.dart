import 'dart:convert';
import 'dart:typed_data';

import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:google_fonts/google_fonts.dart';
import 'package:hexcolor/hexcolor.dart';
import 'package:loading_overlay/loading_overlay.dart';
import 'package:modal_bottom_sheet/modal_bottom_sheet.dart';
import 'package:motion_toast/motion_toast.dart';
import 'package:motion_toast/resources/arrays.dart';
import 'package:rflutter_alert/rflutter_alert.dart';

import '../../models/change-password.dart';
import '../../services/APIService.dart';
import '../Shared/shared_app_bar.dart';

class KorisnickiRacun extends StatefulWidget {
  @override
  State<StatefulWidget> createState() {
    return _KorisnickiRacunState();
  }
}

class _KorisnickiRacunState extends State<KorisnickiRacun> {
  TextEditingController telefonController =
      new TextEditingController(text: APIService.logovaniKorisnik!.telefon);
  TextEditingController emailController =
      new TextEditingController(text: APIService.logovaniKorisnik!.email);
  TextEditingController adresaController =
      new TextEditingController(text: APIService.logovaniKorisnik!.adresa);
  bool _isLoading = false;
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: SharedAppBar(),
      bottomNavigationBar: BottomNavigationBar(
        selectedItemColor: HexColor("#400507"),
        unselectedItemColor: HexColor("#400507"),
        selectedFontSize: 13,
        unselectedFontSize: 13,
        items: [
          BottomNavigationBarItem(
            icon: TextButton(
                onPressed: () {
                  Navigator.of(context).pushNamed('/pocetna');
                },
                child: Icon(
                  Icons.home,
                  color: HexColor("#400507"),
                )),
            label: 'Početna',
          ),
          BottomNavigationBarItem(
            icon: TextButton(
                onPressed: () {
                  Navigator.of(context).pushNamed('/prikaz_rasporeda');
                },
                child: Icon(
                  Icons.calendar_month,
                  color: HexColor("#400507"),
                )),
            label: 'Raspored',
          ),
          BottomNavigationBarItem(
            icon: TextButton(
                onPressed: () {
                  Navigator.of(context).pushNamed('/prikaz_rezultata');
                },
                child: Icon(
                  Icons.sports_soccer,
                  color: HexColor("#400507"),
                )),
            label: 'Rezultati',
          ),
        ],
      ),
      body: Container(
        height: MediaQuery.of(context).size.height,
        decoration: BoxDecoration(
            borderRadius: BorderRadius.circular(10),
            image: DecorationImage(
                fit: BoxFit.cover,
                image: AssetImage('assets/login-background-slika.png'))),
        child: Padding(
          padding: EdgeInsets.only(left: 21, right: 21, top: 15, bottom: 30),
          child: ListView(
            shrinkWrap: true,
            children: [
              Column(
                children: [
                  CircleAvatar(
                    radius: 50,
                    backgroundColor: Colors.white,
                    child: CircleAvatar(
                      radius: 49.5,
                      backgroundColor: Colors.white,
                      child: ClipOval(
                        child: Image.memory(
                          Uint8List.fromList(
                              APIService.logovaniKorisnik!.slika),
                          width: 100,
                          height: 100,
                          fit: BoxFit.cover,
                        ),
                      ),
                    ),
                  ),
                  SizedBox(
                    height: 5,
                  ),
                  Text(
                      (APIService.logovaniKorisnik!.ime +
                              " " +
                              APIService.logovaniKorisnik!.prezime)
                          .toUpperCase(),
                      style: GoogleFonts.oswald(
                          fontSize: 18,
                          color: Colors.black,
                          letterSpacing: 0,
                          fontWeight: FontWeight.bold)),
                  Text(APIService.logovaniKorisnik!.korisnickoIme,
                      style: GoogleFonts.oswald(
                          fontSize: 12,
                          color: Colors.black,
                          letterSpacing: 0,
                          fontWeight: FontWeight.w400)),
                  SizedBox(
                    height: 5,
                  ),
                  APIService.logovaniKorisnik!.isAktivan
                      ? Row(
                          mainAxisAlignment: MainAxisAlignment.center,
                          children: [
                            Icon(
                              Icons.check_circle,
                              color: HexColor("#28A731"),
                              size: 18,
                            ),
                            SizedBox(
                              width: 3,
                            ),
                            Text("Aktivan",
                                style: GoogleFonts.oswald(
                                    fontSize: 14,
                                    color: HexColor("#28A731"),
                                    letterSpacing: 0,
                                    fontWeight: FontWeight.bold))
                          ],
                        )
                      : Row(
                          mainAxisAlignment: MainAxisAlignment.center,
                          children: [
                            Icon(
                              CupertinoIcons.clear_circled_solid,
                              color: Colors.red[800]!,
                              size: 18,
                            ),
                            SizedBox(
                              width: 3,
                            ),
                            Text("Bivši igrač",
                                style: GoogleFonts.oswald(
                                    fontSize: 14,
                                    color: Colors.red[800]!,
                                    letterSpacing: 0,
                                    fontWeight: FontWeight.bold))
                          ],
                        )
                ],
              ),
              Divider(),
              SizedBox(
                height: 5,
              ),
              TextFormField(
                initialValue: (APIService.logovaniKorisnik!.ime +
                    " " +
                    APIService.logovaniKorisnik!.prezime),
                enabled: false,
                readOnly: true,
                decoration: InputDecoration(
                  enabledBorder: OutlineInputBorder(
                    borderRadius: BorderRadius.circular(25.0),
                    borderSide:
                        BorderSide(color: HexColor("#400507"), width: 2),
                  ),
                  focusedBorder: OutlineInputBorder(
                    borderRadius: BorderRadius.circular(25.0),
                    borderSide:
                        BorderSide(color: HexColor("#400507"), width: 2),
                  ),
                  labelStyle: TextStyle(color: HexColor("#400507")),
                  prefixIcon: Padding(
                    padding: EdgeInsets.only(left: 10, right: 10),
                    child: Icon(
                      Icons.person,
                      color: HexColor("#400507"),
                    ),
                  ),
                  labelText: 'Ime i prezime',
                ),
              ),
              SizedBox(
                height: 5,
              ),
              TextFormField(
                initialValue:
                    (APIService.logovaniKorisnik!.drzavljanstvo.nazivDrzave),
                enabled: false,
                readOnly: true,
                decoration: InputDecoration(
                  enabledBorder: OutlineInputBorder(
                    borderRadius: BorderRadius.circular(25.0),
                    borderSide:
                        BorderSide(color: HexColor("#400507"), width: 2),
                  ),
                  focusedBorder: OutlineInputBorder(
                    borderRadius: BorderRadius.circular(25.0),
                    borderSide:
                        BorderSide(color: HexColor("#400507"), width: 2),
                  ),
                  labelStyle: TextStyle(color: HexColor("#400507")),
                  prefixIcon: Padding(
                    padding: EdgeInsets.only(left: 10, right: 10),
                    child: Icon(
                      Icons.flag,
                      color: HexColor("#400507"),
                    ),
                  ),
                  labelText: 'Državljanstvo',
                ),
              ),
              SizedBox(
                height: 5,
              ),
              TextFormField(
                initialValue:
                    (APIService.logovaniKorisnik!.gradRodjenja.nazivGrada),
                enabled: false,
                readOnly: true,
                decoration: InputDecoration(
                  enabledBorder: OutlineInputBorder(
                    borderRadius: BorderRadius.circular(25.0),
                    borderSide:
                        BorderSide(color: HexColor("#400507"), width: 2),
                  ),
                  focusedBorder: OutlineInputBorder(
                    borderRadius: BorderRadius.circular(25.0),
                    borderSide:
                        BorderSide(color: HexColor("#400507"), width: 2),
                  ),
                  labelStyle: TextStyle(color: HexColor("#400507")),
                  prefixIcon: Padding(
                    padding: EdgeInsets.only(left: 10, right: 10),
                    child: Icon(
                      Icons.location_city,
                      color: HexColor("#400507"),
                    ),
                  ),
                  labelText: 'Mjesto rođenja',
                ),
              ),
              SizedBox(
                height: 5,
              ),
              TextFormField(
                initialValue: APIService.logovaniKorisnik!.datumRodjenja,
                enabled: false,
                readOnly: true,
                decoration: InputDecoration(
                  enabledBorder: OutlineInputBorder(
                    borderRadius: BorderRadius.circular(25.0),
                    borderSide:
                        BorderSide(color: HexColor("#400507"), width: 2),
                  ),
                  focusedBorder: OutlineInputBorder(
                    borderRadius: BorderRadius.circular(25.0),
                    borderSide:
                        BorderSide(color: HexColor("#400507"), width: 2),
                  ),
                  labelStyle: TextStyle(color: HexColor("#400507")),
                  prefixIcon: Padding(
                    padding: EdgeInsets.only(left: 10, right: 10),
                    child: Icon(
                      Icons.date_range,
                      color: HexColor("#400507"),
                    ),
                  ),
                  labelText: 'Datum rođenja',
                ),
              ),
              SizedBox(
                height: 5,
              ),
              TextFormField(
                controller: adresaController,
                decoration: InputDecoration(
                  enabledBorder: UnderlineInputBorder(
                    borderSide:
                        BorderSide(color: HexColor("#400507"), width: 2),
                  ),
                  focusedBorder: UnderlineInputBorder(
                    borderSide:
                        BorderSide(color: HexColor("#400507"), width: 2),
                  ),
                  labelStyle: TextStyle(color: HexColor("#400507")),
                  prefixIcon: Padding(
                    padding: EdgeInsets.only(left: 10, right: 10),
                    child: Icon(
                      Icons.location_on,
                      color: HexColor("#400507"),
                    ),
                  ),
                  labelText: 'Adresa prebivališta',
                ),
              ),
              SizedBox(
                height: 5,
              ),
              TextFormField(
                controller: telefonController,
                decoration: InputDecoration(
                  enabledBorder: UnderlineInputBorder(
                    borderSide:
                        BorderSide(color: HexColor("#400507"), width: 2),
                  ),
                  focusedBorder: UnderlineInputBorder(
                    borderSide:
                        BorderSide(color: HexColor("#400507"), width: 2),
                  ),
                  labelStyle: TextStyle(color: HexColor("#400507")),
                  prefixIcon: Padding(
                    padding: EdgeInsets.only(left: 10, right: 10),
                    child: Icon(
                      Icons.phone,
                      color: HexColor("#400507"),
                    ),
                  ),
                  labelText: 'Telefon',
                ),
              ),
              SizedBox(
                height: 5,
              ),
              TextFormField(
                controller: emailController,
                decoration: InputDecoration(
                  enabledBorder: UnderlineInputBorder(
                    borderSide:
                        BorderSide(color: HexColor("#400507"), width: 2),
                  ),
                  focusedBorder: UnderlineInputBorder(
                    borderSide:
                        BorderSide(color: HexColor("#400507"), width: 2),
                  ),
                  labelStyle: TextStyle(color: HexColor("#400507")),
                  prefixIcon: Padding(
                    padding: EdgeInsets.only(left: 10, right: 10),
                    child: Icon(
                      Icons.email,
                      color: HexColor("#400507"),
                    ),
                  ),
                  labelText: 'E-mail',
                ),
              ),
              SizedBox(
                height: 20,
              ),
              TextButton(
                  style: TextButton.styleFrom(
                      padding: EdgeInsets.zero,
                      alignment: Alignment.centerLeft),
                  onPressed: () => {
                        showCupertinoModalBottomSheet(
                          context: context,
                          topRadius: Radius.circular(20),
                          builder: (context) => Container(
                            height: 500,
                            child: Material(child: DodajUrediContext()),
                          ),
                        )
                      },
                  child: Container(
                      decoration: BoxDecoration(
                        color: Colors.amber,
                        borderRadius: BorderRadius.all(Radius.circular(10)),
                        border: Border.all(
                          color: Colors.black26.withOpacity(0.1),
                        ),
                      ),
                      // width: MediaQuery.of(context).size.width - 26,
                      height: 40,
                      child: Padding(
                          padding: EdgeInsets.all(4),
                          child: Row(
                              mainAxisAlignment: MainAxisAlignment.center,
                              children: [
                                Icon(Icons.key, size: 19, color: Colors.black),
                                SizedBox(
                                  width: 5,
                                ),
                                Text("PROMJENA LOZINKE",
                                    style: GoogleFonts.oswald(
                                        fontSize: 15,
                                        color: Colors.black,
                                        letterSpacing: 0,
                                        fontWeight: FontWeight.w700))
                              ])))),
              SizedBox(
                height: 10,
              ),
              TextButton(
                  style: TextButton.styleFrom(
                      padding: EdgeInsets.zero,
                      alignment: Alignment.centerLeft),
                  onPressed: () => {SpasiIzmjeneProfila()},
                  child: Container(
                      decoration: BoxDecoration(
                        color: HexColor("#400507"),
                        borderRadius: BorderRadius.all(Radius.circular(10)),
                        border: Border.all(
                          color: Colors.black26.withOpacity(0.1),
                        ),
                      ),
                      // width: MediaQuery.of(context).size.width - 26,
                      height: 40,
                      child: Padding(
                          padding: EdgeInsets.all(4),
                          child: Row(
                              mainAxisAlignment: MainAxisAlignment.center,
                              children: [
                                Icon(Icons.save_as,
                                    size: 19, color: Colors.white),
                                SizedBox(
                                  width: 5,
                                ),
                                Text("SPASI IZMJENE PROFILA",
                                    style: GoogleFonts.oswald(
                                        fontSize: 15,
                                        color: Colors.white,
                                        letterSpacing: 0,
                                        fontWeight: FontWeight.w700))
                              ])))),
            ],
          ),
        ),
      ),
    );
  }

  Future<void> SpasiIzmjeneProfila() async {
    Map data = {
      'adresa': adresaController.text,
      'telefon': telefonController.text,
      'email': emailController.text,
      'isAktivan': true,
    };
    String dataJsonEncoded = jsonEncode(data);

    setState(() {
      _isLoading = true;
    });

    try {
      var resultPreporuceni = await APIService.Update("Korisnik/UrediKorisnika",
          APIService.logovaniKorisnik!.korisnikId, dataJsonEncoded);
      if (resultPreporuceni != null) {
        MotionToast.success(
          titleStyle: TextStyle(fontWeight: FontWeight.bold),
          description: "Korisnički profil je uspješno uređen!",
          descriptionStyle: TextStyle(fontSize: 12),
          position: MOTION_TOAST_POSITION.TOP,
          animationType: ANIMATION.FROM_TOP,
          height: 60,
        ).show(context);
        setState(() {
          _isLoading = false;
        });
      } else {
        MotionToast.error(
          title: "Greška na serveru!",
          titleStyle: TextStyle(fontWeight: FontWeight.bold),
          description:
              "Desila se neočekivana greška. Za pomoć, javite se administratoru na mail eBordo@outlook.com!",
          descriptionStyle: TextStyle(fontSize: 12),
          position: MOTION_TOAST_POSITION.TOP,
          animationType: ANIMATION.FROM_TOP,
          height: 80,
          toastDuration: Duration(seconds: 4),
        ).show(context);
        setState(() {
          _isLoading = false;
        });
      }
    } catch (e) {
      MotionToast.error(
        title: "Greškaaaa na serveru!",
        titleStyle: TextStyle(fontWeight: FontWeight.bold),
        description:
            "Desila se neočekivana greška. Za pomoć, javite se administratoru na mail eBordo@outlook.com!",
        descriptionStyle: TextStyle(fontSize: 12),
        position: MOTION_TOAST_POSITION.TOP,
        animationType: ANIMATION.FROM_TOP,
        height: 80,
        toastDuration: Duration(seconds: 4),
      ).show(context);
      setState(() {
        _isLoading = false;
      });
    }
  }
}

class DodajUrediContext extends StatefulWidget {
  const DodajUrediContext({
    Key? key,
  }) : super(key: key);

  @override
  State<DodajUrediContext> createState() => _DodajUrediContextState();
}

class _DodajUrediContextState extends State<DodajUrediContext> {
  bool _isLoading = false;
  TextEditingController currentPasswordController = new TextEditingController();
  TextEditingController newPasswordController = new TextEditingController();
  bool _currentPasswordVisible = false;
  bool _newPasswordVisible = false;

  Future<void> PromjenaLozinke(
      int korisnikId, String oldPassword, String newPassword) async {
    ChangePassword search = new ChangePassword(
        korisnikId: korisnikId,
        oldPassword: oldPassword,
        newPassword: newPassword);

    setState(() {
      _isLoading = true;
    });

    try {
      var resultPreporuceni = await APIService.ChangeUserPassword(search);

      if (resultPreporuceni != null) {
        Alert(
            context: context,
            padding: EdgeInsets.only(top: 10, left: 15, right: 15),
            content: Container(
                child: Column(children: [
              Icon(
                Icons.check_circle,
                color: HexColor("#28A731"),
                size: 70,
              ),
              SizedBox(height: 6),
              Text("NOVA LOZINKA JE POSTAVLJENA",
                  style: GoogleFonts.oswald(
                      fontSize: 18,
                      color: Colors.black,
                      letterSpacing: 0,
                      fontWeight: FontWeight.bold)),
            ])),
            buttons: []).show();
        setState(() {
          _isLoading = false;
        });
      } else {
        MotionToast.error(
          title: "Greška na serveru!",
          titleStyle: TextStyle(fontWeight: FontWeight.bold),
          description:
              "Desila se neočekivana greška. Za pomoć, javite se administratoru na mail eBordo@outlook.com!",
          descriptionStyle: TextStyle(fontSize: 12),
          position: MOTION_TOAST_POSITION.TOP,
          animationType: ANIMATION.FROM_TOP,
          height: 80,
          toastDuration: Duration(seconds: 4),
        ).show(context);
        setState(() {
          _isLoading = false;
        });
      }
    } catch (e) {
      MotionToast.error(
        title: "Greška na serveru!",
        titleStyle: TextStyle(fontWeight: FontWeight.bold),
        description:
            "Desila se neočekivana greška. Za pomoć, javite se administratoru na mail eBordo@outlook.com!",
        descriptionStyle: TextStyle(fontSize: 12),
        position: MOTION_TOAST_POSITION.TOP,
        animationType: ANIMATION.FROM_TOP,
        height: 80,
        toastDuration: Duration(seconds: 4),
      ).show(context);
      setState(() {
        _isLoading = false;
      });
    }
  }

  @override
  void initState() {
    super.initState();
  }

  @override
  Widget build(BuildContext context) {
    return LoadingOverlay(
      isLoading: _isLoading,
      opacity: 0.5,
      color: Colors.white,
      progressIndicator: CircularProgressIndicator(
        color: HexColor("#400507"),
      ),
      child: Container(
        decoration: BoxDecoration(
            borderRadius: BorderRadius.only(
                bottomRight: Radius.circular(0),
                bottomLeft: Radius.circular(0)),
            image: DecorationImage(
                opacity: 0.4,
                fit: BoxFit.cover,
                image: AssetImage('assets/login-background-slika.png'))),
        child: Padding(
          padding: EdgeInsets.all(15),
          child: Container(
            child: Column(
              mainAxisAlignment: MainAxisAlignment.start,
              crossAxisAlignment: CrossAxisAlignment.start,
              children: [
                Row(
                    mainAxisAlignment: MainAxisAlignment.spaceBetween,
                    children: [
                      Column(
                          crossAxisAlignment: CrossAxisAlignment.start,
                          children: [
                            Padding(
                              padding: EdgeInsets.only(left: 0),
                              child: Text("POSTAVLJANJE NOVE LOZINKE",
                                  style: GoogleFonts.oswald(
                                      fontSize: 18,
                                      color: Colors.black,
                                      letterSpacing: 0,
                                      fontWeight: FontWeight.bold)),
                            ),
                          ]),
                      Align(
                        alignment: Alignment(1, -1.05),
                        child: InkWell(
                          onTap: () {
                            Navigator.pop(context);
                          },
                          child: Container(
                            decoration: BoxDecoration(
                              color: Colors.grey[200],
                              borderRadius: BorderRadius.circular(12),
                            ),
                            child: Padding(
                              padding: EdgeInsets.all(5),
                              child: Icon(
                                Icons.close,
                                size: 13,
                                color: Colors.black,
                              ),
                            ),
                          ),
                        ),
                      ),
                    ]),
                SizedBox(
                  height: 10,
                ),
                TextFormField(
                  controller: currentPasswordController,
                  obscureText: !_currentPasswordVisible,
                  enableSuggestions: false,
                  autocorrect: false,
                  decoration: InputDecoration(
                    enabledBorder: UnderlineInputBorder(
                      borderRadius: BorderRadius.circular(25.0),
                      borderSide:
                          BorderSide(color: HexColor("#400507"), width: 2),
                    ),
                    focusedBorder: UnderlineInputBorder(
                      borderRadius: BorderRadius.circular(25.0),
                      borderSide:
                          BorderSide(color: HexColor("#400507"), width: 2),
                    ),
                    labelStyle: TextStyle(color: HexColor("#400507")),
                    prefixIcon: Padding(
                      padding: EdgeInsets.only(left: 10),
                      child: Icon(
                        Icons.lock,
                        color: HexColor("#400507"),
                      ),
                    ),
                    labelText: 'Trenutna lozinka',
                    suffixIcon: IconButton(
                      icon: Padding(
                        padding: EdgeInsets.only(right: 16),
                        child: Padding(
                          padding: EdgeInsets.only(right: 10),
                          child: Icon(
                            _currentPasswordVisible
                                ? Icons.visibility
                                : Icons.visibility_off,
                            color: Colors.black,
                            size: 17,
                          ),
                        ),
                      ),
                      onPressed: () {
                        setState(() {
                          _currentPasswordVisible = !_currentPasswordVisible;
                        });
                      },
                    ),
                  ),
                ),
                SizedBox(
                  height: 5,
                ),
                TextFormField(
                  controller: newPasswordController,
                  obscureText: !_newPasswordVisible,
                  enableSuggestions: false,
                  autocorrect: false,
                  decoration: InputDecoration(
                    enabledBorder: UnderlineInputBorder(
                      borderRadius: BorderRadius.circular(25.0),
                      borderSide:
                          BorderSide(color: HexColor("#400507"), width: 2),
                    ),
                    focusedBorder: UnderlineInputBorder(
                      borderRadius: BorderRadius.circular(25.0),
                      borderSide:
                          BorderSide(color: HexColor("#400507"), width: 2),
                    ),
                    labelStyle: TextStyle(color: HexColor("#400507")),
                    prefixIcon: Padding(
                      padding: EdgeInsets.only(left: 10),
                      child: Icon(
                        Icons.lock,
                        color: HexColor("#400507"),
                      ),
                    ),
                    labelText: 'Nova lozinka',
                    suffixIcon: IconButton(
                      icon: Padding(
                        padding: EdgeInsets.only(right: 16),
                        child: Padding(
                          padding: EdgeInsets.only(right: 10),
                          child: Icon(
                            _newPasswordVisible
                                ? Icons.visibility
                                : Icons.visibility_off,
                            color: Colors.black,
                            size: 17,
                          ),
                        ),
                      ),
                      onPressed: () {
                        setState(() {
                          _newPasswordVisible = !_newPasswordVisible;
                        });
                      },
                    ),
                  ),
                ),
                SizedBox(
                  height: 20,
                ),
                TextButton(
                    style: TextButton.styleFrom(
                        padding: EdgeInsets.zero,
                        alignment: Alignment.centerLeft),
                    onPressed: () => {
                          PromjenaLozinke(
                              APIService.logovaniKorisnik!.korisnikId,
                              currentPasswordController.text,
                              newPasswordController.text)
                        },
                    child: Container(
                        decoration: BoxDecoration(
                          color: HexColor("#400507"),
                          borderRadius: BorderRadius.all(Radius.circular(10)),
                          border: Border.all(
                            color: Colors.black26.withOpacity(0.1),
                          ),
                        ),
                        width: MediaQuery.of(context).size.width - 26,
                        height: 40,
                        child: Padding(
                            padding: EdgeInsets.all(4),
                            child: Row(
                                mainAxisAlignment: MainAxisAlignment.center,
                                children: [
                                  Icon(Icons.save_as,
                                      size: 19, color: Colors.white),
                                  SizedBox(
                                    width: 5,
                                  ),
                                  Text("SPASI NOVU LOZINKU",
                                      style: GoogleFonts.oswald(
                                          fontSize: 15,
                                          color: Colors.white,
                                          letterSpacing: 0,
                                          fontWeight: FontWeight.w700))
                                ])))),
              ],
            ),
          ),
        ),
      ),
    );
  }
}
