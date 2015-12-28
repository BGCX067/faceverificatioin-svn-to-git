function y=judge(address)
fid=fopen(address,'r');
syms data;
data=fscanf(fid,'%f');
number=0;
for index1=0:1:199
    min=data(index1*7+1);
    for index2=0:1:6
        if min>data(index1*7+index2+1)
            min=data(index1*7+index2+1);
        end
    end
    if min~=data(index1*7+1)
        number=number+1;
    end
end
number
end