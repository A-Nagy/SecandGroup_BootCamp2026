import 'package:flutter/material.dart';

class ExamplePage extends StatelessWidget
{
  const ExamplePage({super.key});

  @override
  Widget build(BuildContext context) {
    return Directionality(
        textDirection: TextDirection.rtl,
        child:  Scaffold(
          drawer   :Drawer() ,
          endDrawer:Drawer() ,
          appBar   :AppBar(
            title:const Text(
              'Home',
              style: TextStyle(
                color: Colors.white,
                fontWeight: FontWeight.bold,
                fontSize: 28
              ),
            ),
            centerTitle: true,
            leading: Icon(Icons.arrow_back),
            backgroundColor: Colors.blue,
            foregroundColor: Colors.white,
          ) ,
          backgroundColor: Colors.amber,
          body: Center(
            child:Container(
              margin: EdgeInsets.only(top: 200),
              padding: EdgeInsets.symmetric(
                horizontal: 50,
                vertical: 50
              ),
            //  color: Colors.blueGrey,
              child: Text(
                  'Flutter App',
                  style: TextStyle(
                        color: Colors.white,
                        fontWeight: FontWeight.bold,
                        fontSize: 28
                        ),
            ) ,
              decoration: BoxDecoration(
                borderRadius: BorderRadius.circular(50),
                color: Colors.black,
                border: Border.all(
                    width: 8.0,
                color: Colors.red),
                boxShadow: const[
                  BoxShadow(
                    color: Colors.red,
                    blurRadius: 10,
                    offset: Offset(7, 7)
                  ),
                  BoxShadow(
                      color: Colors.grey,
                      blurRadius: 10,
                      offset: Offset(-7, -7)
                  )
                ]

              )
            )
          ),
          floatingActionButton:Container(
            padding: EdgeInsets.zero,
            color : Colors.red,
            height: 80,
            width : 80,
            child : Center(
              child: Text(
                  'Press',
                  style: TextStyle(
                  color: Colors.white,
                  fontWeight: FontWeight.bold,
                  fontSize: 28
              ),
            ),
            ),
          ) ,
          bottomNavigationBar:Container(
            color: Colors.amberAccent,
            height: 80,
          ) ,

        )
    );
  }
}