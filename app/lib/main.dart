import 'package:flutter/material.dart';
import 'signup.dart';
import 'login.dart';
import 'myprofile.dart';

void main() {
  runApp(MyApp());
}

class MyApp extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
        title: 'Test App',
      initialRoute: '/',
      routes: {
        '/': (context) => LogInPage(), 
        '/SignUp': (context) => SignUpPage(),
        '/profile': (context) => ProfilePage(),
      },
      theme: ThemeData(
        primarySwatch: Colors.red,
      ),
    );
  }
}
