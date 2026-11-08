
import 'package:flutter/material.dart';

class ExamplePage5 extends StatefulWidget {
  const ExamplePage5({super.key});

  @override
  State<ExamplePage5> createState() => _ExamplePage5State();
}

class _ExamplePage5State extends State<ExamplePage5> {
  int Counter = 1 ;
  @override
  void initState() {
    super.initState();
  }
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('SataFull',
        style: TextStyle(
            color:Colors.white ,
            fontSize: 30)),
        backgroundColor: Colors.black,
      ),
      body: Column(
        mainAxisAlignment: MainAxisAlignment.center,
        children: [
          Text(
              'Counter : ${Counter} ',
              style: TextStyle(
              fontSize: 60 ,
              color: Colors.purple
              )
          ),
          SizedBox(height: 10),
          Row(
            mainAxisAlignment: MainAxisAlignment.center,
            children: [
              ElevatedButton(
                  onPressed: (){
                 setState(() {
                   Counter++ ;
                 });
                  },
                  child: Text(
                      '+',
                      style: TextStyle(
                          fontSize: 60 ,
                          color: Colors.red
                      )
                  )
              ),
              SizedBox(width: 10),
              ElevatedButton(
                  onPressed: (){
                  setState(() {
                    Counter-- ;
                  });
                  },
                  child: Text(
                      '-',
                      style: TextStyle(
                          fontSize: 60 ,
                          color: Colors.red
                      )
                  )
              ),
            ],
          )

        ],
      ),
    );
  }
}
