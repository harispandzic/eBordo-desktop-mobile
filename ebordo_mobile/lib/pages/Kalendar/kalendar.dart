import 'package:cell_calendar/cell_calendar.dart';
import 'package:ebordo_mobile/models/kalendar.dart';
import 'package:flutter/material.dart';

// ignore_for_file: override_on_non_overriding_member, must_be_immutable
import 'package:ebordo_mobile/services/APIService.dart';
import 'package:hexcolor/hexcolor.dart';
import 'package:loading_overlay/loading_overlay.dart';

import '../Shared/shared_app_bar.dart';

List<CalendarEvent> _sampleEvents = [];

class Kalendar extends StatefulWidget {
  @override
  _KalendarState createState() => _KalendarState();
}

class _KalendarState extends State<Kalendar> {
  final cellCalendarPageController = CellCalendarPageController();
  bool isDataLoading = true;
  @override
  void initState() {
    super.initState();
    Future.delayed(const Duration(seconds: 3), GetKalendar);
  }

  Future<void> GetKalendar() async {
    _sampleEvents = [];
    var result = await APIService.Get("Event", null) as List;

    setState(() {
      isDataLoading = false;
    });

    List<KalendarEvent> kalendar =
        result.map((i) => KalendarEvent.fromJson(i)).toList();

    kalendar.forEach((element) {
      if (element.tipEventa == "UTAKMICA") {
        _sampleEvents.add(
          CalendarEvent(
              eventName: element.opis +
                  " u " +
                  element.satnica +
                  " - " +
                  element.lokacija +
                  " - " +
                  element.trajanje,
              eventDate: DateTime.parse(element.datum),
              eventBackgroundColor: Colors.green),
        );
      } else {
        _sampleEvents.add(
          CalendarEvent(
              eventName: element.opis +
                  " u " +
                  element.satnica +
                  " - " +
                  element.lokacija +
                  " - " +
                  element.trajanje,
              eventDate: DateTime.parse(element.datum),
              eventBackgroundColor: Colors.pink),
        );
      }
    });
  }

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
      body: LoadingOverlay(
        child: Container(
          decoration: BoxDecoration(
              borderRadius: BorderRadius.circular(10),
              image: DecorationImage(
                  fit: BoxFit.cover,
                  image: AssetImage('assets/login-background-slika.png'))),
          child: Padding(
            padding: EdgeInsets.only(top: 10),
            child: CellCalendar(
              cellCalendarPageController: cellCalendarPageController,
              events: _sampleEvents,
              daysOfTheWeekBuilder: (dayIndex) {
                final labels = ["S", "M", "T", "W", "T", "F", "S"];
                return Padding(
                  padding: const EdgeInsets.only(bottom: 4.0),
                  child: Text(
                    labels[dayIndex],
                    style: TextStyle(
                      fontWeight: FontWeight.bold,
                    ),
                    textAlign: TextAlign.center,
                  ),
                );
              },
              monthYearLabelBuilder: (datetime) {
                final year = datetime!.year.toString();
                final month = datetime.month.monthName;
                return Padding(
                  padding: const EdgeInsets.symmetric(vertical: 4),
                  child: Row(
                    children: [
                      const SizedBox(width: 16),
                      Text(
                        "$month  $year",
                        style: TextStyle(
                          fontSize: 24,
                          fontWeight: FontWeight.bold,
                        ),
                      ),
                      const Spacer(),
                      IconButton(
                        padding: EdgeInsets.zero,
                        icon: Icon(Icons.calendar_today),
                        onPressed: () {
                          cellCalendarPageController.animateToDate(
                            DateTime.now(),
                            curve: Curves.linear,
                            duration: Duration(milliseconds: 300),
                          );
                        },
                      )
                    ],
                  ),
                );
              },
              onCellTapped: (date) {
                final eventsOnTheDate = _sampleEvents.where((event) {
                  final eventDate = event.eventDate;
                  return eventDate.year == date.year &&
                      eventDate.month == date.month &&
                      eventDate.day == date.day;
                }).toList();
                showDialog(
                    context: context,
                    builder: (_) => AlertDialog(
                          title: Text(
                              date.month.monthName + " " + date.day.toString()),
                          content: Column(
                            mainAxisSize: MainAxisSize.min,
                            children: eventsOnTheDate
                                .map(
                                  (event) => Container(
                                    width: double.infinity,
                                    padding: EdgeInsets.all(4),
                                    margin: EdgeInsets.only(bottom: 12),
                                    color: event.eventBackgroundColor,
                                    child: Text(
                                      event.eventName,
                                      style: TextStyle(
                                          color: event.eventTextColor),
                                    ),
                                  ),
                                )
                                .toList(),
                          ),
                        ));
              },
              onPageChanged: (firstDate, lastDate) {
                /// Called when the page was changed
                /// Fetch additional events by using the range between [firstDate] and [lastDate] if you want
              },
            ),
          ),
        ),
        isLoading: isDataLoading,
        opacity: 0.5,
        color: Colors.white,
        progressIndicator: CircularProgressIndicator(
          color: HexColor("#400507"),
        ),
      ),
    );
  }
}

// List<CalendarEvent> sampleEvents() {
//   final today = DateTime.now();
//   final sampleEvents = [
//     CalendarEvent(
//         eventName: "New iPhone",
//         eventDate: today.add(Duration(days: -42)),
//         eventBackgroundColor: Colors.black),
//     CalendarEvent(
//         eventName: "Writing test",
//         eventDate: today.add(Duration(days: -30)),
//         eventBackgroundColor: Colors.deepOrange),
//     CalendarEvent(
//         eventName: "Play soccer",
//         eventDate: today.add(Duration(days: -7)),
//         eventBackgroundColor: Colors.greenAccent),
//     CalendarEvent(
//         eventName: "Learn about history",
//         eventDate: today.add(Duration(days: -7))),
//     CalendarEvent(
//         eventName: "Buy new keyboard",
//         eventDate: today.add(Duration(days: -7))),
//     CalendarEvent(
//         eventName: "Walk around the park",
//         eventDate: today.add(Duration(days: -7)),
//         eventBackgroundColor: Colors.deepOrange),
//     CalendarEvent(
//         eventName: "Buy a present for Rebecca",
//         eventDate: today.add(Duration(days: -7)),
//         eventBackgroundColor: Colors.pink),
//     CalendarEvent(
//         eventName: "Firebase", eventDate: today.add(Duration(days: -7))),
//     CalendarEvent(eventName: "Task Deadline", eventDate: today),
//     CalendarEvent(
//         eventName: "Jon's Birthday",
//         eventDate: today.add(Duration(days: 3)),
//         eventBackgroundColor: Colors.green),
//     CalendarEvent(
//         eventName: "Date with Rebecca",
//         eventDate: today.add(Duration(days: 7)),
//         eventBackgroundColor: Colors.pink),
//     CalendarEvent(
//         eventName: "Start to study Spanish",
//         eventDate: today.add(Duration(days: 13))),
//     CalendarEvent(
//         eventName: "Have lunch with Mike",
//         eventDate: today.add(Duration(days: 13)),
//         eventBackgroundColor: Colors.green),
//     CalendarEvent(
//         eventName: "Buy new Play Station software",
//         eventDate: today.add(Duration(days: 13)),
//         eventBackgroundColor: Colors.indigoAccent),
//     CalendarEvent(
//         eventName: "Update my flutter package",
//         eventDate: today.add(Duration(days: 13))),
//     CalendarEvent(
//         eventName: "Watch movies in my house",
//         eventDate: today.add(Duration(days: 21))),
//     CalendarEvent(
//         eventName: "Medical Checkup",
//         eventDate: today.add(Duration(days: 30)),
//         eventBackgroundColor: Colors.red),
//     CalendarEvent(
//         eventName: "Gym",
//         eventDate: today.add(Duration(days: 42)),
//         eventBackgroundColor: Colors.indigoAccent),
//   ];
//   return sampleEvents;
// }
