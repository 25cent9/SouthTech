/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package javaapplication1;

/**
 *
 * @author 707308
 */
public class JavaApplication1 {

    public static void main(String[] args) {
        int x = 0;
        whileExample(x);
        System.out.println("******************");
        doWhileExp(x);
        System.out.println("******************");
        forExp(x);
    }
    public static void whileExample(int num){
        while(num!=20){
            System.out.println("X is "+num);
            num++;
        }
    }
    public static void doWhileExp(int num){
        do{
            System.out.println("X is "+num);
            num++;
        }while(num!=20);
    }
    public static void forExp(int num){
        for(int i = 0; i<20; i++){
            System.out.println("X is "+num);
            num++;
        }
    }
}
