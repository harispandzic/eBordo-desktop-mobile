import 'dart:convert';
import 'dart:typed_data';
import 'package:dropdown_button2/dropdown_button2.dart';
import 'package:ebordo_mobile/models/update-sastav.dart';
import 'package:ebordo_mobile/models/utakmica-sastav.dart';
import 'package:ebordo_mobile/pages/Shared/shared_app_bar.dart';
import 'package:ebordo_mobile/pages/Upravljanje%20igra%C4%8Dima/detalji_igraca.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:flutter_rating_bar/flutter_rating_bar.dart';
import 'package:flutter_slidable/flutter_slidable.dart';
import 'package:google_fonts/google_fonts.dart';
import 'package:hexcolor/hexcolor.dart';
import 'package:intl/intl.dart';
import 'package:loading_overlay/loading_overlay.dart';
import 'package:modal_bottom_sheet/modal_bottom_sheet.dart';
import 'package:motion_toast/motion_toast.dart';
import 'package:motion_toast/resources/arrays.dart';
import '../../models/get-preporuceni.dart';
import '../../models/igrac.dart';
import '../../models/pozicija.dart';
import '../../models/utakmica.dart';
import '../../services/APIService.dart';

int daysBetween(DateTime from, DateTime to) {
  from = DateTime(from.year, from.month, from.day);
  to = DateTime(to.year, to.month, to.day);
  return (to.difference(from).inHours / 24).round();
}

String garnituraDresaSlika = "";
String garnituraDresaNaziv = "";

class DodajUrediContext extends StatefulWidget {
  final String? uloga;
  final List<int>? dodaniIgraci;
  final MyCallback? dodajUPostavu;
  final MyCallbackBrisanje? obrisiIzPostave;
  final int? igracId;
  final int? pozicijaId;
  final int? utakmicaSastavId;

  const DodajUrediContext({
    Key? key,
    this.uloga,
    this.dodaniIgraci,
    this.dodajUPostavu,
    this.obrisiIzPostave,
    this.igracId,
    this.pozicijaId,
    this.utakmicaSastavId,
  }) : super(key: key);

  @override
  State<DodajUrediContext> createState() => _DodajUrediContextState();
}

class _DodajUrediContextState extends State<DodajUrediContext> {
  List<Igrac> _preporuceniIgraciLista = [];
  List<Igrac> _igraciLista = [];
  List<Pozicija> _pozicijeLista = [];
  String? selectedValueIgrac;
  String? selectedValuePozicija;
  bool _isLoading = true;
  bool isUredjivanje = false;

  @override
  void initState() {
    super.initState();
    GetPodatke();
    Future.delayed(const Duration(seconds: 4), () {
      setState(() {
        _isLoading = false;
        if (widget.igracId != 0 && widget.pozicijaId != 0) {
          isUredjivanje = true;
        }
      });
    });
  }

  Future<List<Igrac>> GetPodatke() async {
    Map<String, String>? queryParams = null;
    queryParams = {'pozicijaId': "-1", 'isAktivan': 'true', 'ime': ""};

    var result = await APIService.Get("Igrac", queryParams) as List;

    List<Igrac> igraciList = result.map((i) => Igrac.fromJson(i)).toList();

    if (widget.igracId == 0 && widget.pozicijaId == 0) {
      igraciList = igraciList
          .where((element) => !widget.dodaniIgraci!.contains(element.igracId))
          .toList();
    }

    var resultPozicije = await APIService.Get('Pozicija', null) as List;

    List<Pozicija> pozicijeList =
        resultPozicije.map((i) => Pozicija.fromJson(i)).toList();

    setState(() {
      _igraciLista = igraciList;
      _pozicijeLista = pozicijeList;
      selectedValueIgrac = widget.igracId != 0
          ? widget.igracId.toString()
          : _igraciLista[0].igracId.toString();
      selectedValuePozicija = widget.pozicijaId != 0
          ? widget.pozicijaId.toString()
          : pozicijeList[0].pozicijaId.toString();
    });

    GetPrepouceneIgrace(_igraciLista[0].igracId);

    return igraciList;
  }

  Future<List<Igrac>> GetPrepouceneIgrace(int igracId) async {
    GetPreporuceni search =
        new GetPreporuceni(igracId: igracId, selectedIds: widget.dodaniIgraci!);

    var resultPreporuceni = await APIService.GetPreporuceneIgrace(
        "Igrac", "GetPreporuceneIgrace", search) as List;

    List<Igrac> igraciList =
        resultPreporuceni.map((i) => Igrac.fromJson(i)).toList();

    setState(() {
      _preporuceniIgraciLista = igraciList;
    });

    return igraciList;
  }

  Widget IgracKarticaPreporuceni(Igrac igrac) {
    return TextButton(
      style: TextButton.styleFrom(
          padding: EdgeInsets.only(right: 5),
          minimumSize: Size(60, 60),
          alignment: Alignment.centerLeft),
      onPressed: () {
        Navigator.push(
            context,
            MaterialPageRoute(
                builder: (context) => DetaljiIgraca(
                      igrac: igrac,
                    )));
      },
      child: Container(
          width: 120,
          decoration: BoxDecoration(
              borderRadius: BorderRadius.all(Radius.circular(10)),
              image: DecorationImage(
                  fit: BoxFit.cover,
                  image: AssetImage('assets/igrac-kartica-pozadina.png'))),
          child: Padding(
            padding: EdgeInsets.all(7),
            child: Stack(children: [
              Positioned(
                top: 0.0,
                left: 0,
                right: 0.0,
                child: Text("#" + igrac.brojDresa.toString(),
                    style: GoogleFonts.oswald(
                      fontSize: 10,
                      color: Colors.white,
                      letterSpacing: 0,
                    )),
              ),
              Positioned(
                top: 0,
                left: 90,
                right: 0.0,
                child: CircleAvatar(
                  radius: 8,
                  backgroundColor: Colors.white,
                  child: CircleAvatar(
                    radius: 16,
                    backgroundColor: Colors.white,
                    child: ClipOval(
                      child: Image.memory(
                        Uint8List.fromList(
                            igrac.korisnik.drzavljanstvo.zastava),
                        width: 15,
                        height: 15,
                        fit: BoxFit.cover,
                      ),
                    ),
                  ),
                ),
              ),
              Column(children: [
                Image.memory(Uint8List.fromList(igrac.slikaPanel),
                    fit: BoxFit.cover),
                Row(
                  crossAxisAlignment: CrossAxisAlignment.center,
                  mainAxisAlignment: MainAxisAlignment.center,
                  children: [
                    Text(
                        igrac.korisnik.ime.toString().toUpperCase() +
                            " " +
                            igrac.korisnik.prezime.toString().toUpperCase(),
                        style: GoogleFonts.oswald(
                          fontSize: 13,
                          color: Colors.white,
                          letterSpacing: 0,
                        )),
                  ],
                ),
                Text(
                    igrac.pozicija.skracenica +
                        " - " +
                        igrac.pozicija.nazivPozicije.toString().toUpperCase(),
                    style: GoogleFonts.oswald(
                      fontSize: 7.5,
                      color: Colors.white,
                      letterSpacing: 0,
                    )),
                SizedBox(
                  height: 3,
                ),
                RatingBarIndicator(
                  rating: igrac.igracStatistika.prosjecnaOcjena.toDouble(),
                  itemBuilder: (context, index) => Icon(
                    Icons.star,
                    color: Colors.amber,
                  ),
                  itemCount: 5,
                  itemSize: 10,
                  direction: Axis.horizontal,
                ),
              ]),
            ]),
          )),
    );
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
                              child: Text("DODAVANJE IGRAČA U SASTAV",
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
                  height: 15,
                ),
                Row(
                  mainAxisAlignment: MainAxisAlignment.spaceBetween,
                  children: [
                    Text(
                      "IGRAČ",
                      style: GoogleFonts.oswald(
                          fontSize: 15,
                          color: Colors.black,
                          letterSpacing: 0,
                          fontWeight: FontWeight.bold),
                      textAlign: TextAlign.center,
                    ),
                    TextButton(
                        style: ButtonStyle(alignment: Alignment.centerRight),
                        onPressed: () {
                          Navigator.push(
                              context,
                              MaterialPageRoute(
                                  builder: (context) => DetaljiIgraca(
                                        igrac: _igraciLista
                                            .where((element) =>
                                                element.igracId.toString() ==
                                                selectedValueIgrac)
                                            .first,
                                      )));
                        },
                        child: Icon(
                          Icons.info_outline,
                          color: Colors.black,
                          size: 19,
                        ))
                  ],
                ),
                SizedBox(
                  height: 5,
                ),
                Container(
                  child: DropdownButtonHideUnderline(
                    child: DropdownButton2(
                      buttonDecoration: BoxDecoration(
                        borderRadius: BorderRadius.circular(14),
                        border: Border.all(
                          color: Colors.black26.withOpacity(0.1),
                        ),
                        color: HexColor("#DCDCDC").withOpacity(0.6),
                      ),
                      dropdownPadding: null,
                      dropdownDecoration: BoxDecoration(
                        borderRadius: BorderRadius.circular(14),
                        color: HexColor("#DCDCDC"),
                      ),
                      scrollbarRadius: const Radius.circular(40),
                      scrollbarThickness: 6,
                      scrollbarAlwaysShow: true,
                      buttonWidth: MediaQuery.of(context).size.width - 30,
                      items: _igraciLista
                          .map((item) => DropdownMenuItem<String>(
                              value: item.igracId.toString(),
                              child: Padding(
                                padding: EdgeInsets.only(left: 5, right: 0),
                                child: Row(
                                  children: [
                                    Container(
                                      child: Row(children: [
                                        Container(
                                          height: 40,
                                          child: Padding(
                                            padding: EdgeInsets.only(left: 7),
                                            child: Align(
                                              alignment: Alignment.centerLeft,
                                              child: CircleAvatar(
                                                radius: 16,
                                                backgroundColor: Colors.white,
                                                child: CircleAvatar(
                                                  radius: 15.5,
                                                  backgroundColor: Colors.white,
                                                  child: ClipOval(
                                                    child: Image.memory(
                                                      Uint8List.fromList(
                                                          item.korisnik.slika),
                                                      width: 30,
                                                      height: 30,
                                                      fit: BoxFit.cover,
                                                    ),
                                                  ),
                                                ),
                                              ),
                                            ),
                                          ),
                                        ),
                                        Container(
                                          height: 40,
                                          width: 125,
                                          child: Padding(
                                            padding: EdgeInsets.only(left: 4),
                                            child: Align(
                                              alignment: Alignment.centerLeft,
                                              child: Text(
                                                (item.korisnik.ime[0]
                                                            .toString() +
                                                        ". " +
                                                        item.korisnik.prezime)
                                                    .toString()
                                                    .toUpperCase(),
                                                style: GoogleFonts.oswald(
                                                    fontSize: 15,
                                                    color: Colors.black,
                                                    letterSpacing: 0,
                                                    fontWeight:
                                                        FontWeight.bold),
                                                textAlign: TextAlign.center,
                                              ),
                                            ),
                                          ),
                                        ),
                                        Container(
                                          height: 40,
                                          width: 43,
                                          child: Padding(
                                            padding: EdgeInsets.only(left: 4),
                                            child: Align(
                                              alignment: Alignment.centerLeft,
                                              child: Text(
                                                item.pozicija.skracenica
                                                    .toString()
                                                    .toUpperCase(),
                                                style: GoogleFonts.oswald(
                                                    fontSize: 15,
                                                    color: Colors.black,
                                                    letterSpacing: 0,
                                                    fontWeight:
                                                        FontWeight.bold),
                                                textAlign: TextAlign.center,
                                              ),
                                            ),
                                          ),
                                        ),
                                        Container(
                                          height: 40,
                                          child: Padding(
                                            padding: EdgeInsets.only(left: 4),
                                            child: Align(
                                              alignment: Alignment.centerLeft,
                                              child: RatingBarIndicator(
                                                rating: item.igracStatistika
                                                    .prosjecnaOcjena
                                                    .toDouble(),
                                                itemBuilder: (context, index) =>
                                                    Icon(
                                                  Icons.star,
                                                  color: Colors.amber,
                                                ),
                                                itemCount: 5,
                                                itemSize: 14.0,
                                                direction: Axis.horizontal,
                                              ),
                                            ),
                                          ),
                                        ),
                                      ]),
                                    )
                                  ],
                                ),
                              )))
                          .toList(),
                      value: selectedValueIgrac,
                      onChanged: (value) {
                        setState(() {
                          selectedValueIgrac = value.toString();
                        });
                        GetPrepouceneIgrace(int.parse(value.toString()));
                      },
                    ),
                  ),
                ),
                SizedBox(
                  height: 10,
                ),
                Text(
                  "POZICIJA",
                  style: GoogleFonts.oswald(
                      fontSize: 15,
                      color: Colors.black,
                      letterSpacing: 0,
                      fontWeight: FontWeight.bold),
                  textAlign: TextAlign.center,
                ),
                SizedBox(
                  height: 5,
                ),
                Container(
                  child: DropdownButtonHideUnderline(
                    child: DropdownButton2(
                      buttonDecoration: BoxDecoration(
                        borderRadius: BorderRadius.circular(14),
                        border: Border.all(
                          color: Colors.black26.withOpacity(0.1),
                        ),
                        color: HexColor("#DCDCDC").withOpacity(0.6),
                      ),
                      dropdownPadding: null,
                      dropdownDecoration: BoxDecoration(
                        borderRadius: BorderRadius.circular(14),
                        color: HexColor("#DCDCDC"),
                      ),
                      scrollbarRadius: const Radius.circular(40),
                      scrollbarThickness: 6,
                      scrollbarAlwaysShow: true,
                      buttonWidth: MediaQuery.of(context).size.width - 30,
                      items: _pozicijeLista
                          .map((item) => DropdownMenuItem<String>(
                              value: item.pozicijaId.toString(),
                              child: Padding(
                                padding: EdgeInsets.only(left: 5, right: 5),
                                child: Row(
                                  mainAxisAlignment:
                                      MainAxisAlignment.spaceBetween,
                                  children: [
                                    Container(
                                      height: 40,
                                      child: Padding(
                                        padding: EdgeInsets.only(left: 4),
                                        child: Align(
                                          alignment: Alignment.centerLeft,
                                          child: Text(
                                            (item.nazivPozicije)
                                                .toString()
                                                .toUpperCase(),
                                            style: GoogleFonts.oswald(
                                                fontSize: 15,
                                                color: Colors.black,
                                                letterSpacing: 0,
                                                fontWeight: FontWeight.bold),
                                            textAlign: TextAlign.center,
                                          ),
                                        ),
                                      ),
                                    ),
                                    Container(
                                      height: 40,
                                      child: Padding(
                                        padding: EdgeInsets.only(left: 4),
                                        child: Align(
                                          alignment: Alignment.centerLeft,
                                          child: Text(
                                            item.skracenica
                                                .toString()
                                                .toUpperCase(),
                                            style: GoogleFonts.oswald(
                                                fontSize: 15,
                                                color: Colors.black,
                                                letterSpacing: 0,
                                                fontWeight: FontWeight.bold),
                                            textAlign: TextAlign.center,
                                          ),
                                        ),
                                      ),
                                    ),
                                  ],
                                ),
                              )))
                          .toList(),
                      value: selectedValuePozicija,
                      onChanged: (value) {
                        setState(() {
                          selectedValuePozicija = value.toString();
                        });
                      },
                    ),
                  ),
                ),
                SizedBox(
                  height: 15,
                ),
                Row(
                  children: [
                    Text(
                      "ULOGA: ",
                      style: GoogleFonts.oswald(
                          fontSize: 15,
                          color: Colors.black,
                          letterSpacing: 0,
                          fontWeight: FontWeight.bold),
                      textAlign: TextAlign.center,
                    ),
                    Text(
                      widget.uloga.toString(),
                      style: GoogleFonts.oswald(
                          fontSize: 15,
                          color: HexColor("#400507"),
                          letterSpacing: 0,
                          fontWeight: FontWeight.bold),
                      textAlign: TextAlign.center,
                    ),
                  ],
                ),
                SizedBox(
                  height: 20,
                ),
                Text(
                  "PREPORUČENI IGRAČI ",
                  style: GoogleFonts.oswald(
                      fontSize: 15,
                      color: Colors.black,
                      letterSpacing: 0,
                      fontWeight: FontWeight.bold),
                  textAlign: TextAlign.center,
                ),
                Padding(
                  padding: EdgeInsets.only(left: 3),
                  child: Text(
                    "Dodirni za pregled detalja o igraču!",
                    style: GoogleFonts.oswald(
                      fontSize: 10,
                      color: Colors.black,
                      letterSpacing: 0,
                    ),
                    textAlign: TextAlign.center,
                  ),
                ),
                SizedBox(
                  height: 10,
                ),
                (_preporuceniIgraciLista.length == 0 && !_isLoading)
                    ? Padding(
                        padding: EdgeInsets.only(left: 21, right: 21),
                        child: Center(
                            child: Column(
                          mainAxisAlignment: MainAxisAlignment.center,
                          crossAxisAlignment: CrossAxisAlignment.center,
                          children: [
                            Image.asset("assets/nema-rezultata-pretrage.png",
                                height: 150),
                            Text("NEMA REZULTATA PRETRAGE!",
                                style: GoogleFonts.oswald(
                                    fontSize: 17,
                                    color: Colors.black,
                                    letterSpacing: 0,
                                    fontWeight: FontWeight.bold)),
                            Text("Nisu pronađeni igrači za preporuku!",
                                style: GoogleFonts.oswald(
                                  fontSize: 14.5,
                                  color: Colors.black,
                                  letterSpacing: 0,
                                ),
                                textAlign: TextAlign.center),
                          ],
                        )),
                      )
                    : Container(
                        height: 190,
                        child: ListView(
                          scrollDirection: Axis.horizontal,
                          shrinkWrap: true,
                          children: _preporuceniIgraciLista
                              .map(
                                  (element) => IgracKarticaPreporuceni(element))
                              .toList(),
                        ),
                      ),
                SizedBox(height: 20),
                SizedBox(
                  width: MediaQuery.of(context).size.width - 30,
                  height: 40,
                  child: TextButton.icon(
                      style: TextButton.styleFrom(
                        textStyle: TextStyle(color: Colors.blue),
                        backgroundColor:
                            isUredjivanje ? Colors.amber : HexColor("#400507"),
                        shape: RoundedRectangleBorder(
                          borderRadius: BorderRadius.circular(12),
                        ),
                      ),
                      onPressed: () => {
                            if (isUredjivanje)
                              {
                                widget.obrisiIzPostave!(
                                    igracId: widget.igracId.toString(),
                                    isPrvaPostava:
                                        widget.uloga == "PRVA POSTAVA"
                                            ? true
                                            : false,
                                    isUredjivanje: true),
                              },
                            if (widget.uloga == "PRVA POSTAVA")
                              {
                                widget.dodajUPostavu!(
                                    novi: new UtakmicaSastav(
                                        utakmicaSastavId: 0,
                                        igrac: _igraciLista
                                            .where((element) =>
                                                element.igracId.toString() ==
                                                selectedValueIgrac)
                                            .first,
                                        pozicija: _pozicijeLista
                                            .where((element) =>
                                                element.pozicijaId.toString() ==
                                                selectedValuePozicija)
                                            .first,
                                        uloga: "PRVA_POSTAVA"),
                                    isPrvaPostava: true,
                                    isUredjivanje: isUredjivanje)
                              }
                            else
                              {
                                widget.dodajUPostavu!(
                                    novi: new UtakmicaSastav(
                                        utakmicaSastavId: 0,
                                        igrac: _igraciLista
                                            .where((element) =>
                                                element.igracId.toString() ==
                                                selectedValueIgrac)
                                            .first,
                                        pozicija: _pozicijeLista
                                            .where((element) =>
                                                element.pozicijaId.toString() ==
                                                selectedValuePozicija)
                                            .first,
                                        uloga: "KLUPA"),
                                    isPrvaPostava: false,
                                    isUredjivanje: isUredjivanje)
                              },
                          },
                      icon: Icon(
                          isUredjivanje ? Icons.save : Icons.add_circle_outline,
                          size: 19,
                          color: isUredjivanje ? Colors.black : Colors.white),
                      label: Text(
                          isUredjivanje
                              ? "SPASI IZMJENE U SASTAVU"
                              : "DODAJ IGRAČA U SASTAV",
                          style: GoogleFonts.oswald(
                              fontSize: 14,
                              color:
                                  isUredjivanje ? Colors.black : Colors.white,
                              letterSpacing: 0,
                              fontWeight: FontWeight.w700))),
                ),
              ],
            ),
          ),
        ),
      ),
    );
  }
}

typedef void MyCallback(
    {UtakmicaSastav novi, bool isPrvaPostava, bool? isUredjivanje});

class DetaljiUtakmice extends StatefulWidget {
  final Utakmica? utakmica;

  DetaljiUtakmice({Key? key, this.utakmica}) : super(key: key);

  @override
  _DetaljiUtakmiceState createState() => _DetaljiUtakmiceState();
}

class _DetaljiUtakmiceState extends State<DetaljiUtakmice> {
  List<UtakmicaSastav> prvaPostava = [];
  List<UtakmicaSastav> klupa = [];
  bool isPodaciPromjenjeni = false;

  VoidCallback? dodajUPostavu(
      {UtakmicaSastav? novi, bool? isPrvaPostava, bool? isUredjivanje}) {
    if (isPrvaPostava!) {
      setState(() {
        prvaPostava.add(novi!);
      });
    } else {
      setState(() {
        klupa.add(novi!);
      });
    }
    setState(() {
      isPodaciPromjenjeni = true;
    });
    Navigator.pop(context);

    if (!isUredjivanje!) {
      MotionToast.success(
        titleStyle: TextStyle(fontWeight: FontWeight.bold),
        description: "Igrač je uspješno dodan u sastav!",
        descriptionStyle: TextStyle(fontSize: 12),
        position: MOTION_TOAST_POSITION.TOP,
        animationType: ANIMATION.FROM_TOP,
        height: 60,
      ).show(context);
    } else {
      MotionToast.info(
        titleStyle: TextStyle(fontWeight: FontWeight.bold),
        description: "Sastav je uspješno uređen!",
        descriptionStyle: TextStyle(fontSize: 12),
        position: MOTION_TOAST_POSITION.TOP,
        animationType: ANIMATION.FROM_TOP,
        height: 60,
      ).show(context);
    }
  }

  Future<void>? obrisiIzPostave(
      {String? igracId,
      bool? isPrvaPostava,
      int? sastavId,
      bool? isUredjivanje}) async {
    UtakmicaSastav sastav;

    if (isPrvaPostava!) {
      sastav = prvaPostava
          .where((element) => element.igrac.igracId.toString() == igracId)
          .first;
      setState(() {
        prvaPostava.removeWhere(
            (element) => element.igrac.igracId.toString() == igracId);
      });
    } else {
      sastav = klupa
          .where((element) => element.igrac.igracId.toString() == igracId)
          .first;
      setState(() {
        klupa.removeWhere(
            (element) => element.igrac.igracId.toString() == igracId);
      });
    }
    setState(() {
      isPodaciPromjenjeni = true;
    });
    if (sastavId != 0 && sastavId != null) {
      await APIService.DeleteById("UtakmicaSastav", sastavId!);
    }
    if (!isUredjivanje!) {
      MotionToast.success(
        titleStyle: TextStyle(fontWeight: FontWeight.bold),
        description: "Igrač je uspješno obrisan iz sastava!",
        descriptionStyle: TextStyle(fontSize: 12),
        position: MOTION_TOAST_POSITION.TOP,
        animationType: ANIMATION.FROM_TOP,
        height: 60,
      ).show(context);
    }
  }

  @override
  void initState() {
    if (prvaPostava.length == 0) {
      GetSastav();
    }
    if (widget.utakmica!.tipGarniture == "Domaća") {
      garnituraDresaSlika = 'assets/domaci.png';
      garnituraDresaNaziv = "DOMAĆA GARNITURA";
    } else if (widget.utakmica!.tipGarniture == "Gostujuća") {
      garnituraDresaSlika = 'assets/gostujuci.png';
      garnituraDresaNaziv = "GOSTUJUĆA GARNITURA";
    } else {
      garnituraDresaSlika = 'assets/rezervni.png';
      garnituraDresaNaziv = "REZERVNA GARNITURA";
    }
  }

  void GetSastav() {
    List<UtakmicaSastav> tempPrvaPostava = [];
    List<UtakmicaSastav> tempKlupa = [];
    widget.utakmica!.sastav.forEach((element) {
      if (element.uloga == "PRVA_POSTAVA") {
        tempPrvaPostava.add(element);
      } else {
        tempKlupa.add(element);
      }
    });
    setState(() {
      prvaPostava = tempPrvaPostava;
      klupa = tempKlupa;
    });
  }

  Widget _getFAB() {
    if (!isPodaciPromjenjeni || !APIService.logovaniKorisnik!.isTrener) {
      return Container();
    } else {
      return FloatingActionButton.extended(
        onPressed: () async {
          await UrediUtakmicu();
        },
        backgroundColor: Colors.amber,
        icon: Icon(
          Icons.save,
          color: Colors.black,
        ),
        label: Text("SPASI",
            style: GoogleFonts.oswald(
                fontSize: 16,
                color: Colors.black,
                letterSpacing: 0,
                fontWeight: FontWeight.w600)),
      );
    }
  }

  Future<void> UrediUtakmicu() async {
    List<UpdateSastav> sastav = [];

    prvaPostava.forEach((element) {
      sastav.add(new UpdateSastav(
          utakmicaSastavid: element.utakmicaSastavId,
          igracId: element.igrac.igracId,
          utakmicaId: widget.utakmica!.utakmicaId,
          pozicijaId: element.pozicija.pozicijaId,
          uloga: element.uloga));
    });
    klupa.forEach((element) {
      sastav.add(new UpdateSastav(
          utakmicaSastavid: element.utakmicaSastavId,
          igracId: element.igrac.igracId,
          utakmicaId: widget.utakmica!.utakmicaId,
          pozicijaId: element.pozicija.pozicijaId,
          uloga: element.uloga));
    });

    Map data = {
      'datumOdigravanja': widget.utakmica!.datumOdigravanja,
      'satnica': widget.utakmica!.satnica,
      'napomene': widget.utakmica!.napomene,
      'kapitenId': widget.utakmica!.kapiten.igracId,
      'sastav': sastav,
    };
    String dataJsonEncoded = jsonEncode(data);

    APIService.Update("Utakmica", widget.utakmica!.utakmicaId, dataJsonEncoded);

    MotionToast.info(
      titleStyle: TextStyle(fontWeight: FontWeight.bold),
      description: "Utakmica uspješno uređena!",
      descriptionStyle: TextStyle(fontSize: 12),
      position: MOTION_TOAST_POSITION.TOP,
      animationType: ANIMATION.FROM_TOP,
      height: 60,
    ).show(context);
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      floatingActionButton: _getFAB(),
      appBar: SharedAppBar(),
      body: ListView(
        children: [
          Container(
              decoration: BoxDecoration(
                  borderRadius: BorderRadius.only(
                      bottomRight: Radius.circular(0),
                      bottomLeft: Radius.circular(0)),
                  image: DecorationImage(
                      fit: BoxFit.cover,
                      image: AssetImage('assets/login-background-slika.png'))),
              child: Padding(
                padding:
                    EdgeInsets.only(left: 13, top: 10, right: 13, bottom: 30),
                child: Column(
                  mainAxisAlignment: MainAxisAlignment.start,
                  crossAxisAlignment: CrossAxisAlignment.start,
                  children: [
                    Row(
                      mainAxisAlignment: MainAxisAlignment.spaceBetween,
                      children: [
                        Text("DETALJI O UTAKMICI",
                            style: GoogleFonts.oswald(
                                fontSize: 18,
                                color: HexColor("#400507"),
                                letterSpacing: 0,
                                fontWeight: FontWeight.bold)),
                        Padding(
                          padding: EdgeInsets.only(right: 0),
                          child: Image.asset(
                            'assets/grb-animacija.gif',
                            fit: BoxFit.contain,
                            height: 35,
                          ),
                        ),
                      ],
                    ),
                    SizedBox(
                      height: 20,
                    ),
                    widget.utakmica!.vrstaUtakmice == "Domaća"
                        ? Row(
                            mainAxisAlignment: MainAxisAlignment.spaceBetween,
                            crossAxisAlignment: CrossAxisAlignment.center,
                            children: [
                              Row(
                                mainAxisAlignment:
                                    MainAxisAlignment.spaceBetween,
                                children: [
                                  Container(
                                    child: Image.asset(
                                      'assets/fksarajevo-grb.png',
                                      fit: BoxFit.contain,
                                      height: 40,
                                      width: 40,
                                    ),
                                  ),
                                  SizedBox(width: 7),
                                  Text("SARAJEVO",
                                      style: GoogleFonts.oswald(
                                          fontSize: 19,
                                          color: Colors.black,
                                          letterSpacing: 0,
                                          fontWeight: FontWeight.w600)),
                                ],
                              ),
                              Container(
                                child: Image.memory(
                                  Uint8List.fromList(
                                      widget.utakmica!.takmicenje.logo),
                                  height: 40,
                                  width: 40,
                                ),
                              )
                            ],
                          )
                        : Row(
                            mainAxisAlignment: MainAxisAlignment.spaceBetween,
                            crossAxisAlignment: CrossAxisAlignment.center,
                            children: [
                              Row(
                                mainAxisAlignment:
                                    MainAxisAlignment.spaceBetween,
                                children: [
                                  Container(
                                    child: Image.memory(
                                      Uint8List.fromList(
                                          widget.utakmica!.protivnik.grb),
                                      height: 40,
                                      width: 40,
                                    ),
                                  ),
                                  SizedBox(width: 7),
                                  Text(
                                      widget.utakmica!.protivnik.nazivKluba
                                          .toString()
                                          .toUpperCase(),
                                      style: GoogleFonts.oswald(
                                          fontSize: 19,
                                          color: Colors.black,
                                          letterSpacing: 0,
                                          fontWeight: FontWeight.w600)),
                                ],
                              ),
                              Container(
                                child: Image.memory(
                                  Uint8List.fromList(
                                      widget.utakmica!.takmicenje.logo),
                                  height: 40,
                                  width: 40,
                                ),
                              )
                            ],
                          ),
                    SizedBox(height: 10),
                    widget.utakmica!.vrstaUtakmice == "Gostujuća"
                        ? Row(
                            mainAxisAlignment: MainAxisAlignment.spaceBetween,
                            crossAxisAlignment: CrossAxisAlignment.center,
                            children: [
                              Row(
                                mainAxisAlignment:
                                    MainAxisAlignment.spaceBetween,
                                children: [
                                  Container(
                                    child: Image.asset(
                                      'assets/fksarajevo-grb.png',
                                      fit: BoxFit.contain,
                                      height: 40,
                                      width: 40,
                                    ),
                                  ),
                                  SizedBox(width: 7),
                                  Text("SARAJEVO",
                                      style: GoogleFonts.oswald(
                                          fontSize: 19,
                                          color: Colors.black,
                                          letterSpacing: 0,
                                          fontWeight: FontWeight.w600)),
                                ],
                              ),
                            ],
                          )
                        : Row(
                            mainAxisAlignment: MainAxisAlignment.spaceBetween,
                            crossAxisAlignment: CrossAxisAlignment.center,
                            children: [
                              Row(
                                mainAxisAlignment:
                                    MainAxisAlignment.spaceBetween,
                                children: [
                                  Container(
                                    child: Image.memory(
                                      Uint8List.fromList(
                                          widget.utakmica!.protivnik.grb),
                                      height: 40,
                                      width: 40,
                                    ),
                                  ),
                                  SizedBox(width: 7),
                                  Text(
                                      widget.utakmica!.protivnik.nazivKluba
                                          .toString()
                                          .toUpperCase(),
                                      style: GoogleFonts.oswald(
                                          fontSize: 19,
                                          color: Colors.black,
                                          letterSpacing: 0,
                                          fontWeight: FontWeight.w600)),
                                ],
                              ),
                            ],
                          ),
                    SizedBox(height: 10),
                    Row(children: [
                      Icon(
                        widget.utakmica!.vrstaUtakmice == "Gostujuća"
                            ? CupertinoIcons.airplane
                            : Icons.home,
                        color: HexColor("#400507"),
                        size: 18,
                      ),
                      SizedBox(
                        width: 5,
                      ),
                      Text(
                          widget.utakmica!.vrstaUtakmice == "Domaća"
                              ? "DOMAĆA UTAKMICA"
                              : "GOSTUJUĆA UTAKMICA",
                          style: GoogleFonts.oswald(
                            fontSize: 14,
                            color: Colors.black,
                            letterSpacing: 0,
                          )),
                    ]),
                    SizedBox(
                      height: 6,
                    ),
                    Row(children: [
                      Icon(
                        Icons.emoji_events,
                        color: HexColor("#400507"),
                        size: 18,
                      ),
                      SizedBox(
                        width: 5,
                      ),
                      Text(
                          widget.utakmica!.opisUtakmice
                              .toString()
                              .toUpperCase(),
                          style: GoogleFonts.oswald(
                            fontSize: 14,
                            color: Colors.black,
                            letterSpacing: 0,
                          )),
                      SizedBox(
                        width: 5,
                      ),
                      Image.memory(
                        Uint8List.fromList(widget.utakmica!.takmicenje.logo),
                        height: 18,
                        fit: BoxFit.cover,
                      )
                    ]),
                    SizedBox(
                      height: 6,
                    ),
                    Row(children: [
                      Icon(
                        Icons.calendar_month,
                        color: HexColor("#400507"),
                        size: 18,
                      ),
                      SizedBox(
                        width: 5,
                      ),
                      Text(
                          DateFormat.yMMMd()
                              .format(DateTime.parse(
                                  widget.utakmica!.datumOdigravanja))
                              .toString(),
                          style: GoogleFonts.oswald(
                            fontSize: 14,
                            color: Colors.black,
                            letterSpacing: 0,
                          )),
                      SizedBox(
                        width: 10,
                      ),
                      Container(
                        decoration: BoxDecoration(
                            color: HexColor("#FFC107"),
                            borderRadius: BorderRadius.all(Radius.circular(5))),
                        child: Padding(
                          padding: EdgeInsets.only(left: 7, right: 7),
                          child: Text(
                              "za " +
                                  daysBetween(
                                          DateTime.now(),
                                          DateTime.parse(widget
                                              .utakmica!.datumOdigravanja))
                                      .toString() +
                                  " dana",
                              style: GoogleFonts.oswald(
                                  fontSize: 10,
                                  color: Colors.black,
                                  letterSpacing: 0,
                                  fontWeight: FontWeight.w500)),
                        ),
                      )
                    ]),
                    SizedBox(
                      height: 6,
                    ),
                    Row(children: [
                      Icon(
                        Icons.access_alarm,
                        color: HexColor("#400507"),
                        size: 18,
                      ),
                      SizedBox(
                        width: 5,
                      ),
                      Text(widget.utakmica!.satnica + " h",
                          style: GoogleFonts.oswald(
                            fontSize: 14,
                            color: Colors.black,
                            letterSpacing: 0,
                          ))
                    ]),
                    SizedBox(
                      height: 6,
                    ),
                    Row(children: [
                      Icon(
                        Icons.location_on,
                        color: HexColor("#400507"),
                        size: 18,
                      ),
                      SizedBox(
                        width: 5,
                      ),
                      Text(
                          "STADION " +
                              widget.utakmica!.stadion.nazivStadiona
                                  .toString()
                                  .toUpperCase() +
                              ", " +
                              widget.utakmica!.stadion.lokacijaStadiona
                                  .nazivGrada,
                          style: GoogleFonts.oswald(
                            fontSize: 14,
                            color: Colors.black,
                            letterSpacing: 0,
                          )),
                      SizedBox(
                        width: 5,
                      ),
                      CircleAvatar(
                        radius: 8,
                        backgroundColor: Colors.white,
                        child: CircleAvatar(
                          radius: 16,
                          backgroundColor: Colors.white,
                          child: ClipOval(
                            child: Image.memory(
                              Uint8List.fromList(widget.utakmica!.stadion
                                  .lokacijaStadiona.drzava.zastava),
                              width: 15.5,
                              height: 15.5,
                              fit: BoxFit.cover,
                            ),
                          ),
                        ),
                      ),
                    ]),
                    SizedBox(
                      height: 6,
                    ),
                    Row(children: [
                      Icon(
                        Icons.sports,
                        color: HexColor("#400507"),
                        size: 18,
                      ),
                      SizedBox(
                        width: 5,
                      ),
                      Text(widget.utakmica!.sudija.toString().toUpperCase(),
                          style: GoogleFonts.oswald(
                            fontSize: 14,
                            color: Colors.black,
                            letterSpacing: 0,
                          )),
                    ]),
                    SizedBox(
                      height: 6,
                    ),
                    Row(children: [
                      Image.asset(
                        garnituraDresaSlika,
                        fit: BoxFit.contain,
                        height: 18,
                        width: 18,
                      ),
                      SizedBox(
                        width: 5,
                      ),
                      Text(garnituraDresaNaziv,
                          style: GoogleFonts.oswald(
                            fontSize: 14,
                            color: Colors.black,
                            letterSpacing: 0,
                          ))
                    ]),
                    SizedBox(height: 6),
                    Text("KAPITEN",
                        style: GoogleFonts.oswald(
                            fontSize: 15,
                            color: Colors.black,
                            letterSpacing: 0,
                            fontWeight: FontWeight.bold)),
                    SizedBox(height: 3),
                    Row(
                      children: [
                        CircleAvatar(
                          radius: 14,
                          backgroundColor: Colors.white,
                          child: CircleAvatar(
                            radius: 13.5,
                            backgroundColor: Colors.white,
                            child: ClipOval(
                              child: Image.memory(
                                Uint8List.fromList(
                                    widget.utakmica!.kapiten.korisnik.slika),
                                width: 50,
                                height: 50,
                                fit: BoxFit.cover,
                              ),
                            ),
                          ),
                        ),
                        SizedBox(width: 5),
                        Text(
                            widget.utakmica!.kapiten.korisnik.ime
                                    .toString()
                                    .toUpperCase() +
                                " " +
                                widget.utakmica!.kapiten.korisnik.prezime
                                    .toString()
                                    .toUpperCase(),
                            style: GoogleFonts.oswald(
                                fontSize: 15,
                                color: Colors.black,
                                letterSpacing: 0,
                                fontWeight: FontWeight.bold)),
                        SizedBox(
                          height: 20,
                        ),
                      ],
                    ),
                  ],
                ),
              )),
          SizedBox(
            height: 20,
          ),
          Padding(
            padding: EdgeInsets.only(left: 13, top: 10, right: 13, bottom: 30),
            child: Container(
                child: Column(
              mainAxisAlignment: MainAxisAlignment.start,
              crossAxisAlignment: CrossAxisAlignment.start,
              children: [
                Text("POČETNA POSTAVA",
                    style: GoogleFonts.oswald(
                        fontSize: 18,
                        color: Colors.black,
                        letterSpacing: 0,
                        fontWeight: FontWeight.bold)),
                SizedBox(
                  height: 10,
                ),
                ListView(
                  scrollDirection: Axis.vertical,
                  shrinkWrap: true,
                  children: prvaPostava
                      .map((element) => IgracNastupKartica(
                          context,
                          element,
                          obrisiIzPostave,
                          dodajUPostavu,
                          true,
                          prvaPostava,
                          klupa))
                      .toList(),
                ),
                if (prvaPostava.length < 11 &&
                    APIService.logovaniKorisnik!.isTrener)
                  TextButton(
                      style: TextButton.styleFrom(
                          padding: EdgeInsets.zero,
                          alignment: Alignment.centerLeft),
                      onPressed: () => {
                            showCupertinoModalBottomSheet(
                              context: context,
                              topRadius: Radius.circular(20),
                              builder: (context) => Container(
                                height: MediaQuery.of(context).size.height - 60,
                                child: Material(
                                  child: DodajUrediContext(
                                      uloga: "PRVA POSTAVA",
                                      dodaniIgraci: [
                                        ...prvaPostava
                                            .map((e) => e.igrac.igracId)
                                            .toList(),
                                        ...klupa
                                            .map((e) => e.igrac.igracId)
                                            .toList()
                                      ],
                                      dodajUPostavu: dodajUPostavu,
                                      obrisiIzPostave: obrisiIzPostave,
                                      igracId: 0,
                                      pozicijaId: 0),
                                ),
                              ),
                            )
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
                                    Icon(Icons.add_circle_outline,
                                        size: 19, color: Colors.white),
                                    SizedBox(
                                      width: 5,
                                    ),
                                    Text("DODAJ IGRAČA U PRVU POSTAVU",
                                        style: GoogleFonts.oswald(
                                            fontSize: 15,
                                            color: Colors.white,
                                            letterSpacing: 0,
                                            fontWeight: FontWeight.w700))
                                  ])))),
                if (prvaPostava.length == 11)
                  Container(
                    padding: EdgeInsets.only(top: 10),
                    child: Row(children: [
                      Icon(
                        Icons.check_circle,
                        color: HexColor("#28A731"),
                        size: 23,
                      ),
                      SizedBox(
                        width: 4,
                      ),
                      Text("PRVA POSTAVA USPJEŠNO ODABRANA!",
                          style: GoogleFonts.oswald(
                              fontSize: 15,
                              color: HexColor("#28A731"),
                              letterSpacing: 0,
                              fontWeight: FontWeight.w700))
                    ]),
                  ),
                if (prvaPostava.length < 11 &&
                    !APIService.logovaniKorisnik!.isTrener)
                  Container(
                    padding: EdgeInsets.only(top: 10),
                    child: Row(children: [
                      Icon(
                        Icons.pending,
                        color: Colors.amber,
                        size: 23,
                      ),
                      SizedBox(
                        width: 4,
                      ),
                      Text("IGRAČI ZA PRVU POSTAVU NISU ODABRANI!",
                          style: GoogleFonts.oswald(
                              fontSize: 15,
                              color: Colors.amber,
                              letterSpacing: 0,
                              fontWeight: FontWeight.w700))
                    ]),
                  ),
                SizedBox(
                  height: 20,
                ),
                Text("KLUPA",
                    style: GoogleFonts.oswald(
                        fontSize: 18,
                        color: Colors.black,
                        letterSpacing: 0,
                        fontWeight: FontWeight.bold)),
                SizedBox(
                  height: 10,
                ),
                ListView(
                  scrollDirection: Axis.vertical,
                  shrinkWrap: true,
                  children: klupa
                      .map((element) => IgracNastupKartica(
                          context,
                          element,
                          obrisiIzPostave,
                          dodajUPostavu,
                          false,
                          prvaPostava,
                          klupa))
                      .toList(),
                ),
                if (klupa.length < 9 && APIService.logovaniKorisnik!.isTrener)
                  TextButton(
                      style: TextButton.styleFrom(
                          padding: EdgeInsets.only(right: 0),
                          alignment: Alignment.centerLeft),
                      onPressed: () => {
                            showCupertinoModalBottomSheet(
                              context: context,
                              topRadius: Radius.circular(20),
                              builder: (context) => Container(
                                height: MediaQuery.of(context).size.height - 60,
                                child: Material(
                                  child: DodajUrediContext(
                                      uloga: "KLUPA",
                                      dodaniIgraci: [
                                        ...prvaPostava
                                            .map((e) => e.igrac.igracId)
                                            .toList(),
                                        ...klupa
                                            .map((e) => e.igrac.igracId)
                                            .toList()
                                      ],
                                      dodajUPostavu: dodajUPostavu,
                                      obrisiIzPostave: obrisiIzPostave,
                                      igracId: 0,
                                      pozicijaId: 0),
                                ),
                              ),
                            )
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
                                    Icon(Icons.add_circle_outline,
                                        size: 19, color: Colors.white),
                                    SizedBox(
                                      width: 5,
                                    ),
                                    Text("DODAJ IGRAČA NA KLUPU",
                                        style: GoogleFonts.oswald(
                                            fontSize: 15,
                                            color: Colors.white,
                                            letterSpacing: 0,
                                            fontWeight: FontWeight.w700))
                                  ])))),
                if (klupa.length == 9)
                  Container(
                    padding: EdgeInsets.only(top: 10),
                    child: Row(children: [
                      Icon(
                        Icons.check_circle,
                        color: HexColor("#28A731"),
                        size: 23,
                      ),
                      SizedBox(
                        width: 4,
                      ),
                      Text("KLUPA USPJEŠNO ODABRANA!",
                          style: GoogleFonts.oswald(
                              fontSize: 15,
                              color: HexColor("#28A731"),
                              letterSpacing: 0,
                              fontWeight: FontWeight.w700))
                    ]),
                  ),
                if (klupa.length < 9 && !APIService.logovaniKorisnik!.isTrener)
                  Container(
                    padding: EdgeInsets.only(top: 10),
                    child: Row(children: [
                      Icon(
                        Icons.pending,
                        color: Colors.amber,
                        size: 23,
                      ),
                      SizedBox(
                        width: 4,
                      ),
                      Text("IGRAČI ZA KLUPU NISU ODABRANI!",
                          style: GoogleFonts.oswald(
                              fontSize: 15,
                              color: Colors.amber,
                              letterSpacing: 0,
                              fontWeight: FontWeight.w700))
                    ]),
                  ),
                SizedBox(
                  height: 20,
                ),
                Divider(),
                Text("TRENER",
                    style: GoogleFonts.oswald(
                        fontSize: 15,
                        color: Colors.black,
                        letterSpacing: 0,
                        fontWeight: FontWeight.bold)),
                SizedBox(height: 3),
                Row(
                  children: [
                    CircleAvatar(
                      radius: 14,
                      backgroundColor: Colors.white,
                      child: CircleAvatar(
                        radius: 13.5,
                        backgroundColor: Colors.white,
                        child: ClipOval(
                          child: Image.memory(
                            Uint8List.fromList(
                                widget.utakmica!.trener.korisnik.slika),
                            width: 30,
                            height: 30,
                            fit: BoxFit.cover,
                          ),
                        ),
                      ),
                    ),
                    SizedBox(width: 3),
                    Text(
                        widget.utakmica!.trener.korisnik.ime
                                .toString()
                                .toUpperCase() +
                            " " +
                            widget.utakmica!.trener.korisnik.prezime
                                .toString()
                                .toUpperCase(),
                        style: GoogleFonts.oswald(
                            fontSize: 15,
                            color: Colors.black,
                            letterSpacing: 0,
                            fontWeight: FontWeight.bold)),
                  ],
                )
              ],
            )),
          ),
        ],
      ),
    );
  }
}

typedef void MyCallbackBrisanje(
    {String igracId, bool isPrvaPostava, int? sastavId, bool? isUredjivanje});

Widget IgracNastupKartica(
    BuildContext context,
    UtakmicaSastav element,
    MyCallbackBrisanje obrisiUzPostave,
    MyCallback dodajUPostavu,
    bool isPrvaPostava,
    prvaPostava,
    klupa) {
  return Container(
    margin: EdgeInsets.only(bottom: 5),
    child: Slidable(
      key: UniqueKey(),
      endActionPane: ActionPane(
        motion: ScrollMotion(),
        children: [
          if (APIService.logovaniKorisnik!.isTrener)
            Expanded(
              flex: 1,
              child: Align(
                alignment: Alignment.center,
                child: InkWell(
                  onTap: () {
                    obrisiUzPostave(
                        igracId: element.igrac.igracId.toString(),
                        isPrvaPostava: isPrvaPostava,
                        sastavId: element.utakmicaSastavId,
                        isUredjivanje: false);
                  },
                  borderRadius: BorderRadius.only(
                      topLeft: Radius.circular(10),
                      bottomLeft: Radius.circular(10)),
                  child: Container(
                      margin: EdgeInsets.only(right: 1, left: 3),
                      alignment: Alignment.center,
                      decoration: BoxDecoration(
                          color: Color(0xFFFE4A49),
                          borderRadius: BorderRadius.only(
                              topLeft: Radius.circular(10),
                              bottomLeft: Radius.circular(10))),
                      child: Icon(
                        Icons.delete,
                        color: Colors.white,
                      )),
                ),
              ),
            ),
          if (APIService.logovaniKorisnik!.isTrener)
            Expanded(
              flex: 1,
              child: Align(
                alignment: Alignment.center,
                child: InkWell(
                  onTap: () {
                    showCupertinoModalBottomSheet(
                        context: context,
                        topRadius: Radius.circular(20),
                        builder: (context) => Container(
                            height: MediaQuery.of(context).size.height - 60,
                            child: Material(
                              child: DodajUrediContext(
                                  uloga: element.uloga == "PRVA_POSTAVA"
                                      ? "PRVA POSTAVA"
                                      : "KLUPA",
                                  dodaniIgraci: [
                                    ...prvaPostava
                                        .map((e) => e.igrac.igracId)
                                        .toList(),
                                    ...klupa
                                        .map((e) => e.igrac.igracId)
                                        .toList(),
                                  ],
                                  dodajUPostavu: dodajUPostavu,
                                  obrisiIzPostave: obrisiUzPostave,
                                  igracId: element.igrac.igracId,
                                  pozicijaId: element.pozicija.pozicijaId,
                                  utakmicaSastavId: element.utakmicaSastavId),
                            )));
                  },
                  borderRadius: BorderRadius.circular(0),
                  child: Container(
                      margin: EdgeInsets.only(right: 1),
                      alignment: Alignment.center,
                      decoration: BoxDecoration(
                          color: Colors.amber,
                          borderRadius: BorderRadius.circular(0)),
                      child: Icon(
                        Icons.edit,
                        color: Colors.black,
                      )),
                ),
              ),
            ),
          Expanded(
            flex: 1,
            child: Align(
              alignment: Alignment.center,
              child: InkWell(
                onTap: () {
                  Navigator.push(
                      context,
                      MaterialPageRoute(
                          builder: (context) => DetaljiIgraca(
                                igrac: element.igrac,
                              )));
                },
                borderRadius: BorderRadius.only(
                    topRight: Radius.circular(10),
                    bottomRight: Radius.circular(10)),
                child: Container(
                    margin: EdgeInsets.only(
                        left: !APIService.logovaniKorisnik!.isTrener ? 3 : 0),
                    alignment: Alignment.center,
                    decoration: BoxDecoration(
                        color: Color(0xFF21B7CA),
                        borderRadius: BorderRadius.only(
                            topRight: Radius.circular(10),
                            bottomRight: Radius.circular(10),
                            topLeft: !APIService.logovaniKorisnik!.isTrener
                                ? Radius.circular(10)
                                : Radius.circular(0),
                            bottomLeft: !APIService.logovaniKorisnik!.isTrener
                                ? Radius.circular(10)
                                : Radius.circular(0))),
                    child: Icon(
                      Icons.info,
                      color: Colors.white,
                    )),
              ),
            ),
          )
        ],
      ),
      child: TextButton(
        style: TextButton.styleFrom(
            padding: EdgeInsets.zero,
            minimumSize: Size(40, 40),
            alignment: Alignment.centerLeft),
        onPressed: () {
          Navigator.push(
              context,
              MaterialPageRoute(
                  builder: (context) => DetaljiIgraca(
                        igrac: element.igrac,
                      )));
        },
        child: Container(
          decoration: BoxDecoration(
            borderRadius: BorderRadius.circular(10),
            color: HexColor("#DCDCDC"),
          ),
          child: Row(
            children: [
              Container(
                width: 45,
                height: 40,
                decoration: BoxDecoration(
                    borderRadius: BorderRadius.only(
                        topLeft: Radius.circular(10),
                        bottomLeft: Radius.circular(10)),
                    color: HexColor("#400507")),
                child: Padding(
                  padding: EdgeInsets.only(left: 7),
                  child: Align(
                    alignment: Alignment.centerLeft,
                    child: Text(
                      "#" + element.igrac.brojDresa.toString(),
                      style: GoogleFonts.oswald(
                          fontSize: 17,
                          color: Colors.white,
                          letterSpacing: 0,
                          fontWeight: FontWeight.bold),
                      textAlign: TextAlign.center,
                    ),
                  ),
                ),
              ),
              Container(
                height: 40,
                child: Padding(
                  padding: EdgeInsets.only(left: 7),
                  child: Align(
                    alignment: Alignment.centerLeft,
                    child: CircleAvatar(
                      radius: 16,
                      backgroundColor: Colors.white,
                      child: CircleAvatar(
                        radius: 15.5,
                        backgroundColor: Colors.white,
                        child: ClipOval(
                          child: Image.memory(
                            Uint8List.fromList(element.igrac.korisnik.slika),
                            width: 30,
                            height: 30,
                            fit: BoxFit.cover,
                          ),
                        ),
                      ),
                    ),
                  ),
                ),
              ),
              Container(
                height: 40,
                width: 125,
                child: Padding(
                  padding: EdgeInsets.only(left: 4),
                  child: Align(
                    alignment: Alignment.centerLeft,
                    child: Text(
                      (element.igrac.korisnik.ime[0].toString() +
                              ". " +
                              element.igrac.korisnik.prezime)
                          .toString()
                          .toUpperCase(),
                      style: GoogleFonts.oswald(
                          fontSize: 15,
                          color: Colors.black,
                          letterSpacing: 0,
                          fontWeight: FontWeight.bold),
                      textAlign: TextAlign.center,
                    ),
                  ),
                ),
              ),
              Container(
                height: 40,
                width: 50,
                child: Padding(
                  padding: EdgeInsets.only(left: 4),
                  child: Align(
                    alignment: Alignment.centerLeft,
                    child: Text(
                      element.pozicija.skracenica.toString().toUpperCase(),
                      style: GoogleFonts.oswald(
                          fontSize: 15,
                          color: Colors.black,
                          letterSpacing: 0,
                          fontWeight: FontWeight.bold),
                      textAlign: TextAlign.center,
                    ),
                  ),
                ),
              ),
              Container(
                height: 40,
                child: Padding(
                  padding: EdgeInsets.only(left: 4),
                  child: Align(
                    alignment: Alignment.centerLeft,
                    child: RatingBarIndicator(
                      rating: element.igrac.igracStatistika.prosjecnaOcjena
                          .toDouble(),
                      itemBuilder: (context, index) => Icon(
                        Icons.star,
                        color: Colors.amber,
                      ),
                      itemCount: 5,
                      itemSize: 14.0,
                      direction: Axis.horizontal,
                    ),
                  ),
                ),
              ),
            ],
          ),
        ),
      ),
    ),
  );
}
