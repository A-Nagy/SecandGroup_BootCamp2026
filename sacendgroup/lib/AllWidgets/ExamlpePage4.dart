import 'package:flutter/material.dart';

class ExamplePage4 extends StatelessWidget {
  const ExamplePage4({super.key});

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text(
          'Example Page 4 ' ,
          style: TextStyle(
            fontWeight: FontWeight.bold,
            fontSize: 28 ,
            color: Colors.white
          ),),
        backgroundColor: Colors.blue,
      ),
      body: Column(
        children: [
          ElevatedButton(
              onPressed: (){}, child: Text('ElevatedButton')),
          TextButton(
              onPressed: (){},
              child: Text('Text Button')),
          OutlinedButton(
              onPressed: (){},
              child:Text('OutlinedButton')),
          ElevatedButton(
              onPressed: (){}, child: Icon(Icons.home)),
          TextButton(
              onPressed: (){},
              child: Icon(Icons.home)),
          OutlinedButton(
              onPressed: (){},
              child:Icon(Icons.home)),
          OutlinedButton(
              onPressed: (){},
              child:SizedBox(
                width: 100,
              child: Row(
                mainAxisAlignment: MainAxisAlignment.spaceBetween,
                children: [
                  Icon(Icons.add_box_rounded),
                  Text('Add')
                ],
              ),)),
          SizedBox(height: 10),
          GestureDetector(
            onTap: (){
              print('Tapped!');
            },
            onLongPress: (){
              print('Long Press!');
            },
            onDoubleTap: () {
              print('Double Tap!');
            },
            child: Text('Gesture Detector'),
          ),
          InkWell(
            onTap: (){
              print('InkWell tapped!');
            },
            borderRadius: BorderRadius.circular(8),
            child: Container(
              padding: EdgeInsets.all(16),
              decoration: BoxDecoration(
                color: Colors.amber,
                borderRadius: BorderRadius.circular(8),
              ),
              child: Text( 'InkWell (with ripple)',style: TextStyle(color: Colors.black,),),
            ),
          ),
          InkResponse(
            onTap: (){
              print('InkResponse tapped!');
            },
            radius: 30,
            child: Icon(Icons.favorite,size: 40,color: Colors.red,),
          ),
          GestureDetector(
            onTap: () {
              print('Image tapped');
            },
            child: Image.network(
              'https://picsum.photos/200',
              width: 120,
              height: 120,
            ),
          ),
          Container(
            decoration: BoxDecoration(
                border: Border.all(
                  color: Colors.blue,
                  style: BorderStyle.solid,
                  width: 2,
                ),
                borderRadius: BorderRadius.circular(20)),
            child: ListTile(
              leading: Icon(Icons.person),
              title: Text('Profile') ,
              subtitle:Text('Go to profile page') ,
              trailing: const Icon(Icons.arrow_forward_ios),
              onTap: (){
                print('ListTile tapped!');
              },
            ),
          )
        ],
      ),
    );
  }
}
