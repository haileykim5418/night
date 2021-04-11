package serial3;

import java.io.IOException;

import jssc.SerialPort;
import jssc.SerialPortException;
import jssc.SerialPortList;

public class MySerial {
   public static void main(String[] args) {
      String[] portName = 
         SerialPortList.getPortNames();
      for (int i=0; i<portName.length; i++) {
         System.out.println("��밡�� ��Ʈ: " + portName[i]);
      }
      SerialPort serialPort = new SerialPort(portName[0]);
      
      try {
         serialPort.openPort();
         serialPort.setParams(SerialPort.BAUDRATE_9600,
               SerialPort.DATABITS_8 ,
               SerialPort.STOPBITS_1,
               SerialPort.PARITY_NONE);
         System.out.println("��Ʈ ��� ����!");
      } catch (SerialPortException e) {
         e.printStackTrace();
      }
      
      ReadThread rt = new ReadThread(serialPort);
      rt.start();
      WriteThread wt = new WriteThread(serialPort);
      wt.start();
//      try {
//         serialPort.closePort();
//         System.out.println("��Ʈ ����!");
//      } catch (SerialPortException e) {
//         e.printStackTrace();
//      }
   }
}

class ReadThread extends Thread {
   SerialPort serial;
   
   public ReadThread(SerialPort serial) {
      this.serial = serial;
   }

   @Override
   public void run() {
      while (true) {
         try {
            byte[] read = serial.readBytes();
            if (read != null && read.length > 0) {
//               System.out.print(new String(read));
               String data = new String(read);
               System.out.print(data);
            }
         } catch (SerialPortException e) {
            e.printStackTrace();
         }
      }
   }
}

class WriteThread extends Thread {
   SerialPort serial;
   
   public WriteThread(SerialPort serial) {
      this.serial = serial;
   }
   
   public void run() {
      int c = 0;
      try {
         while ((c=System.in.read()) > -1) {
            serial.writeInt(c);
         }
      } catch (IOException e) {
         e.printStackTrace();
      } catch (SerialPortException e) {
         e.printStackTrace();
      }
   }
}

