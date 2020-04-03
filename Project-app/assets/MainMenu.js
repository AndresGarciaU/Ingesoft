import React,{Component} from 'react';
import { StyleSheet, Text, View,TextInput,Button } from 'react-native';
export default class MainMenu extends React.Component {
    render(){
        const{navigate}=this.props.navigation;
       return (
       <View style={{
         backgroundColor:'black',
         justifyContent:'center',
       
         alignContent:'center',  width:'100%',
         height:'100%'
   
   
   
       }}>
         
         <Text style={{
             textAlign:'center',
             fontSize:'50',
             color:'red'
   
            }}>Galaga</Text> 
           
         
         <Button 
         title="Start"
         color='blue'
         onPress={()=> navigate('NameScreen'
         )}
          />
         
         
   <View/>
   
   </View>
   );}}