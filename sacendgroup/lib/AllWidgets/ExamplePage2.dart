import 'package:flutter/material.dart';

class ExamplePage2 extends StatelessWidget
{
  const ExamplePage2({super.key});

  @override
  Widget build(BuildContext context) {
    return  Scaffold(
      drawer   :Drawer() ,
      endDrawer:Drawer() ,
      appBar   :AppBar(
        title:const Text('Home'),
        centerTitle: true,
        leading: Icon(Icons.arrow_back),
        backgroundColor: Colors.blue,
        foregroundColor: Colors.white,
      ) ,
      backgroundColor: Colors.grey,
      body:Container(
        color: Colors.blueGrey,
        child: Text('Flutter App'),
      ) ,
      floatingActionButton:Container(
        color : Colors.red,
        height: 80,
        width : 80,
        child : Text('Press'),
      ) ,
      bottomNavigationBar:Container(
        color: Colors.amberAccent,
        height: 80,
      ) ,

    );
  }
}