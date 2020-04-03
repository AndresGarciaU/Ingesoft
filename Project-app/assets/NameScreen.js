import React,{ Component }  from 'react';
import {Text,View,TextInput,Button,StyleSheet} from 'react-native';


export default class Likes extends React.Component{
    render(){
      const{navigate}=this.props.navigation;
        return(
            <View style={styles.container}>
            
            <TextInput
              style={styles.input}
              placeholder="Iniciar sesion"
              placeholderTextColor='red'
              color='red'

              
            />
            <TextInput
              style={styles.input}
              placeholder="Registrarse"
              placeholderTextColor='red'
              color='red'
            />
            <Button 
         title="Continue"
         color='blue'
         onPress={()=> navigate('Game'
         )}
          />

            

            </View>
            
        );
    }
}


const styles = StyleSheet.create({
    container: {
      flex: 1,
      backgroundColor:'black',
      alignItems: 'center',
      justifyContent: 'center'
    },
    input:{
        fontSize:30,
       
      alignItems: 'center',
      justifyContent: 'center'
    }

});