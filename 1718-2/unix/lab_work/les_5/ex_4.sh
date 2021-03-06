#!/bin/bash

TMP=veverka
TMP2=veverka2
touch veverka veverka2

while read -r line
do 
	IFS=' ' read -r -a array <<< "$line"
	read -r -a array <<< "$line"

	for word in "${array[@]}"
	do
		echo "$word" >> $TMP
	done
done < $1

#| sed -e 's=[0-9]==g' 
cat $TMP | sort | uniq -c | sort -rn |sed 's/^.\{,6\}//g'
rm $TMP
