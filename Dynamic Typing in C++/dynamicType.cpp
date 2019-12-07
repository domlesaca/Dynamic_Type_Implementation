#include<stdlib.h>
#include<iostream>
#include<string>
#include<stdlib.h>
#include<typeinfo>
#include<utility>
#include<bits/stdc++.h>
using namespace std;

class var{
    public:
    int Integer;
    bool Int=false;
    float Float;
    bool Flt=false;
    bool Bool;
    bool Bl=false;
    char Char;
    bool Chr=false;
    string String;
    bool Str=false;
    int *Array;
    bool Arr=false;
    string Error;
    bool Err=false;
    var(){

    }
    var(int a){                                     //Integer
        Integer=a;
        Int=true;
    }
    var(float a){                                   //Float
        Float=a;
        Flt=true;
    }
    var(bool a){                                    //Boolean
        Bool=a;
        Bl=true;
    }
    var(char a){                                    //Character
        Char=a;
        Chr=true;
    }
    var(char a[]){                                  //String
        String=a;
        Str=true;
    }
    var(int a[]){                                    //Integer Array, Needs work though!
        Array=a;
        Arr=true;
    }
    void type(){
        if(Int){
            cout<<endl<<"type: Integer";
        }
        if(Flt){
            cout<<endl<<"type: Float";
        }
        if(Bl){
            cout<<endl<<"type: Boolean";
        }
        if(Chr){
            cout<<endl<<"type: Character";
        }
        if(Str){
            cout<<endl<<"type: String";
        }
    }
    var operator +(var &b){
        var res;
        int i;
        if(Int){

            if(b.Int){      //Integer Sum



                return b.Integer+Integer;
            }
            else if(b.Flt){             //Int + Float gives Integer!


                return b.Float+Integer;
            }
            else{
                cout<<"Cannot use + operator ";
                type();
                cout<<" with ";
                b.type();
                return res;
            }

        }
        else if(Flt){           //Float Sum

            if(b.Int){          //Int + Float gives Integer!



                return float(b.Integer)+Float;
            }
            else if(b.Flt){

                return b.Float+Float;
            }
            else{
                cout<<"Cannot use + operator ";
                type();
                cout<<" with ";
                b.type();
                return res;
            }
        }
        else if(Str){                   //String Concatenation
            if(b.Str){
                char s[(String+b.String).length() +1];
                strcpy(s,(String+b.String).c_str());
                return s;
            }
            else{
                cout<<"Cannot use + operator ";
                type();
                cout<<" with ";
                b.type();
                return res;
            }
        }
        else{
            cout<<"Cannot use + operator ";
            type();
            cout<<" with ";
            b.type();
            return res;
        }
    }
    var operator -(var &b){
        var res;
        int i;
        if(Int){

            if(b.Int){      //Integer Difference



                return Integer-b.Integer;
            }
            else if(b.Flt){             //Int - Float gives Integer!


                return Integer-b.Float;
            }
            else{
                cout<<"Cannot use - operator ";
                type();
                cout<<" with ";
                b.type();
                return res;
            }

        }
        else if(Flt){           //Float Difference

            if(b.Int){          //Int - Float gives Integer!



                return Float-float(b.Integer);
            }
            else if(b.Flt){

                return Float-b.Float;
            }
            else{
                cout<<"Cannot use - operator ";
                type();
                cout<<" with ";
                b.type();
                return res;
            }
        }
        else{
            cout<<"Cannot use - operator ";
            type();
            cout<<" with ";
            b.type();
            return res;
        }
    }
    var operator *(var &b){
        var res;
        int i;
        if(Int){

            if(b.Int){      //Integer Multiplication



                return Integer*b.Integer;
            }
            else if(b.Flt){             //Int * Float gives Integer!


                return Integer*b.Float;
            }
            else{
                cout<<"Cannot use * operator ";
                type();
                cout<<" with ";
                b.type();
                return res;
            }

        }
        else if(Flt){           //Float Multiplication

            if(b.Int){          //Int * Float gives Integer!



                return Float*float(b.Integer);
            }
            else if(b.Flt){

                return Float*b.Float;
            }
            else{
                cout<<"Cannot use * operator ";
                type();
                cout<<" with ";
                b.type();
                return res;
            }
        }
        else{
            cout<<"Cannot use * operator ";
            type();
            cout<<" with ";
            b.type();
            return res;
        }
    }
    var operator /(var &b){
        var res;
        int i;
        if(Int){

            if(b.Int){      //Integer Division



                return Integer/b.Integer;
            }
            else if(b.Flt){             //Int / Float gives Integer!


                return Integer/b.Float;
            }
            else{
                cout<<"Cannot use / operator ";
                type();
                cout<<" with ";
                b.type();
                return res;
            }

        }
        else if(Flt){           //Float Division

            if(b.Int){          //Int / Float gives Integer!



                return Float/float(b.Integer);
            }
            else if(b.Flt){

                return Float/b.Float;
            }
            else{
                cout<<"Cannot use / operator ";
                type();
                cout<<" with ";
                b.type();
                return res;
            }
        }
        else{
            cout<<"Cannot use / operator ";
            type();
            cout<<" with ";
            b.type();
            return res;
        }
    }
    var operator %(var &b){
        var res;
        int i;
        if(Int){

            if(b.Int){      //Integer Mod



                return Integer%b.Integer;
            }
            else if(b.Flt){             //Int % Float gives Integer!


                return Integer%int(b.Float);
            }
            else{
                cout<<"Cannot use % operator ";
                type();
                cout<<" with ";
                b.type();
                return res;
            }

        }
        else if(Flt){           //Float Mod

            if(b.Int){          //Int % Float gives Integer!



                return int(Float)%(b.Integer);
            }
            else if(b.Flt){

                return int(Float)%int(b.Float);
            }
            else{
                cout<<"Cannot use % operator ";
                type();
                cout<<" with ";
                b.type();
                return res;
            }
        }
        /*
        else if(Str){                   //String Concatenation
            if(b.Str){
                char s[(String+b.String).length() +1];
                strcpy(s,(String+b.String).c_str());
                return s;
            }
            else{
                cout<<"Cannot use + operator ";
                type();
                cout<<" with ";
                b.type();
                return res;
            }
        }*/
        else{
            cout<<"Cannot use % operator ";
            type();
            cout<<" with ";
            b.type();
            return res;
        }
    }
    var operator &&(var &b){
        var res;
        int i;
        if(Int){

            if(b.Int){      //Integer And operator



                return (Integer && b.Integer);
            }
            else if(b.Flt){             //Int && Float gives Integer for Boolean!


                return (Integer && b.Float);
            }
            else{
                cout<<"Cannot use && operator ";
                type();
                cout<<" with ";
                b.type();
                return res;
            }

        }
        else if(Flt){           //Float And Operation

            if(b.Int){          //Int && Float gives Integer!



                return (Float && float(b.Integer));
            }
            else if(b.Flt){

                return (Float && b.Float);
            }
            else{
                cout<<"Cannot use && operator ";
                type();
                cout<<" with ";
                b.type();
                return res;
            }
        }
        else{
            cout<<"Cannot use && operator ";
            type();
            cout<<" with ";
            b.type();
            return res;
        }
    }
    var operator ||(var &b){
        var res;
        int i;
        if(Int){

            if(b.Int){      //Integer OR operator



                return (Integer || b.Integer);
            }
            else if(b.Flt){             //Int || Float gives Integer for Boolean!


                return (Integer || b.Float);
            }
            else{
                cout<<"Cannot use || operator ";
                type();
                cout<<" with ";
                b.type();
                return res;
            }

        }
        else if(Flt){           //Float OR Operator

            if(b.Int){          //Int || Float gives Integer!



                return (Float || float(b.Integer));
            }
            else if(b.Flt){

                return (Float || b.Float);
            }
            else{
                cout<<"Cannot use || operator ";
                type();
                cout<<" with ";
                b.type();
                return res;
            }
        }
        else{
            cout<<"Cannot use || operator ";
            type();
            cout<<" with ";
            b.type();
            return res;
        }
    }
    var operator ==(var &b){
        var res;
        int i;
        if(Int){

            if(b.Int){      //Integer Comparison operator



                return (Integer == b.Integer);
            }
            else if(b.Flt){             //Int == Float gives Integer for Boolean!


                return (Integer == b.Float);
            }
            else{
                cout<<"Cannot use == operator ";
                type();
                cout<<" with ";
                b.type();
                return res;
            }

        }
        else if(Flt){           //Float Comparison Operator

            if(b.Int){          //Int == Float gives Integer for Boolean!



                return (Float == float(b.Integer));
            }
            else if(b.Flt){

                return (Float == b.Float);
            }
            else{
                cout<<"Cannot use == operator ";
                type();
                cout<<" with ";
                b.type();
                return res;
            }
        }
        else{
            cout<<"Cannot use == operator ";
            type();
            cout<<" with ";
            b.type();
            return res;
        }
    }
    var operator <=(var &b){
        var res;
        int i;
        if(Int){

            if(b.Int){      //Integer Comparison operator



                return (Integer <= b.Integer);
            }
            else if(b.Flt){             //Int <= Float gives Integer for Boolean!


                return (Integer <= b.Float);
            }
            else{
                cout<<"Cannot use <= operator ";
                type();
                cout<<" with ";
                b.type();
                return res;
            }

        }
        else if(Flt){           //Float Comparison Operator

            if(b.Int){          //Int <= Float gives Integer for Boolean!



                return (Float <= float(b.Integer));
            }
            else if(b.Flt){

                return (Float <= b.Float);
            }
            else{
                cout<<"Cannot use <= operator ";
                type();
                cout<<" with ";
                b.type();
                return res;
            }
        }
        else{
            cout<<"Cannot use <= operator ";
            type();
            cout<<" with ";
            b.type();
            return res;
        }
    }
    var operator >=(var &b){
        var res;
        int i;
        if(Int){

            if(b.Int){      //Integer Comparison operator



                return (Integer >= b.Integer);
            }
            else if(b.Flt){             //Int >= Float gives Integer for Boolean!


                return (Integer >= b.Float);
            }
            else{
                cout<<"Cannot use >= operator ";
                type();
                cout<<" with ";
                b.type();
                return res;
            }

        }
        else if(Flt){           //Float Comparison Operator

            if(b.Int){          //Int >= Float gives Integer for Boolean!



                return (Float >= float(b.Integer));
            }
            else if(b.Flt){

                return (Float >= b.Float);
            }
            else{
                cout<<"Cannot use >= operator ";
                type();
                cout<<" with ";
                b.type();
                return res;
            }
        }
        else{
            cout<<"Cannot use >= operator ";
            type();
            cout<<" with ";
            b.type();
            return res;
        }
    }
    var operator <(var &b){
        var res;
        int i;
        if(Int){

            if(b.Int){      //Integer Comparison operator



                return (Integer < b.Integer);
            }
            else if(b.Flt){             //Int < Float gives Integer for Boolean!


                return (Integer < b.Float);
            }
            else{
                cout<<"Cannot use < operator ";
                type();
                cout<<" with ";
                b.type();
                return res;
            }

        }
        else if(Flt){           //Float Comparison Operator

            if(b.Int){          //Int < Float gives Integer for Boolean!



                return (Float < float(b.Integer));
            }
            else if(b.Flt){

                return (Float < b.Float);
            }
            else{
                cout<<"Cannot use < operator ";
                type();
                cout<<" with ";
                b.type();
                return res;
            }
        }
        else{
            cout<<"Cannot use < operator ";
            type();
            cout<<" with ";
            b.type();
            return res;
        }
    }
    var operator >(var &b){
        var res;
        int i;
        if(Int){

            if(b.Int){      //Integer Comparison operator



                return (Integer > b.Integer);
            }
            else if(b.Flt){             //Int > Float gives Integer for Boolean!


                return (Integer > b.Float);
            }
            else{
                cout<<"Cannot use > operator ";
                type();
                cout<<" with ";
                b.type();
                return res;
            }

        }
        else if(Flt){           //Float Comparison Operator

            if(b.Int){          //Int > Float gives Integer for Boolean!



                return (Float > float(b.Integer));
            }
            else if(b.Flt){

                return (Float > b.Float);
            }
            else{
                cout<<"Cannot use > operator ";
                type();
                cout<<" with ";
                b.type();
                return res;
            }
        }
        else{
            cout<<"Cannot use > operator ";
            type();
            cout<<" with ";
            b.type();
            return res;
        }
    }
    var operator ++(){
        var res;
        if(Int){
            return Integer+1;
        }
        else if(Flt){
            return Float+1;
        }
        else{
            cout<<"Cannot use ++ operator ";
            type();
            return res;
        }
    }
    var operator +=(int a){
        var res;
        if(Int){
            for(int i=0;i<a;i++){
                Integer++;
            }
            return Integer;
        }
        else if(Flt){
            for(int i=0;i<a;i++){
                Float++;
            }
            return Float;
        }
        else{
            cout<<"Cannot use += operator ";
            type();
            return res;
        }
    }

    var operator --(){
        var res;
        if(Int){
            return Integer--;
        }
        else if(Flt){
            return Float--;
        }
        else{
            cout<<"Cannot use -- operator ";
            type();
            return res;
        }
    }
    var operator -=(int a){
        var res;
        if(Int){
            for(int i=0;i<a;i++){
                Integer--;
            }
            return Integer;
        }
        else if(Flt){
            for(int i=0;i<a;i++){
                Float--;
            }
            return Float;
        }
        else{
            cout<<"Cannot use -= operator ";
            type();
            return res;
        }
    }
    var operator !(){
        var res;
        if(Int){
            return !(Integer);
        }
        else if(Flt){
            return !(Float);
        }
        else{
            cout<<"Cannot use ! operator ";
            type();
            return res;
        }
    }
    void print(){
        if(Int){
            cout<<endl;
            cout<<Integer;
        }
        if(Flt){
            cout<<endl;
            cout<<float(Float);
        }
        if(Bl){
            cout<<endl;
            cout<<bool(Bool);
        }
        if(Chr){
            cout<<endl;
            cout<<Char;
        }
        if(Str){
            cout<<endl;
            cout<<String;
        }
        if(Arr){                             //Trying to implement Integer Array
            cout<<endl;
            for(int i=0;i<sizeof(Array);i++){
                cout<<endl<<Array[i]<<',';
            }
        }

    }
};
int main(){
    var a=3.5f;         //add a subscript 'f' for Float
    var b=2.3f;
    var c=(a+b);
    c.print();
    var d=(a-b);
    d.print();
    var e=(a*b);
    e.print();
    var f=(a/b);
    f.print();
    var s=(a==b);
    s.print();
    var r=(a>=b);
    r.print();
    var q=(a<=b);
    q.print();
    var g=(a>b);
    g.print();
    var h=(a<b);
    h.print();
    var i=(a%b);
    i.print();
    var j=(a&&b);
    j.print();
    var k=(a||b);
    k.print();
    var l=(!b);
    l.print();
    var m=(a+=3);
    m.print();
    var n=(a-=2);
    n.print();
    var o=(++a);
    o.print();
    var p=(--b);
    p.print();

}
