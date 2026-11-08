import 'package:flutter/material.dart';
import 'package:sacendgroup/AllWidgets/ExamplePage5.dart';
import 'package:sacendgroup/AllWidgets/ExamplePage6.dart';
import 'package:sacendgroup/AllWidgets/ExamplePage7.dart';

 void main()
{
  runApp(const MyApp());
}
class MyApp extends StatelessWidget
{
  const MyApp({super.key});

  @override
  Widget build(BuildContext context) {
    return  const MaterialApp(
      title: 'Flutter Demo' ,
      home :Examplepage7(),
      debugShowCheckedModeBanner: false,
    ) ;
  }
}





