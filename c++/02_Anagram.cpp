#include <iostream>
#include <map>

using namespace std;

bool validAnagram(string wordOne, string wordTwo){

    map<char, int> myMap;
    for (int i = 0;i< wordOne.length();i++){
        if (myMap.find(wordOne[i]) != myMap.end()) {
            myMap[wordOne[i]] = myMap[wordOne[i]] + 1;
        }else{
            myMap[wordOne[i]] = 1;
        }
    }

    map<char, int> myMap2;
    for (int i = 0;i< wordTwo.length();i++){
        if (myMap2.find(wordOne[i]) != myMap2.end()) {
            myMap2[wordTwo[i]] = myMap2[wordTwo[i]] + 1;
        }else{
            myMap2[wordTwo[i]] = 1;
        }
    }
    
    for (const auto& x : myMap) {
        if (myMap[x.first] != myMap2[x.first]){
            return false;
        }
    }
    return true;
}


int main(){
    if(validAnagram("car", "tar")==1){
        cout << "True" << endl ;
    }else{
        cout << "False" << endl;
    }
}

