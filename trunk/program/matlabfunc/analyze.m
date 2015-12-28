function [ output_args ] = analyze( address,inputimgaddress )
numofpics=200;
syms containername;
length=40;
width=40;
matrix=zeros(numofpics,length*width);
for num=1:1:numofpics
    if num<10
        containername=strcat(address,'FERET-','00',num2str(num),'\01.tif');
        image=imread(containername);
        image=imresize(image,[40,40]);
        reimage=double(reshape(image,1,length*width));
        reimage=reimage/norm(reimage);
        matrix(num,:)=reimage;
        continue;
    end
    if num<100
        containername=strcat(address,'FERET-','0',num2str(num),'\01.tif');
        image=imread(containername);
        image=imresize(image,[40,40]);
        reimage=double(reshape(image,1,length*width));
        reimage=reimage/norm(reimage);
        matrix(num,:)=reimage;
        continue;
    end
    if num<201
        containername=strcat(address,'FERET-',num2str(num),'\01.tif');
        image=imread(containername);
        image=imresize(image,[40,40]);
        reimage=double(reshape(image,1,length*width));
        reimage=reimage/norm(reimage);
        matrix(num,:)=reimage;
        continue;
    end
end
meanX=mean(matrix);
for index=1:1:numofpics
    matrix(index,:)=matrix(index,:)-meanX;
end
covariance=cov(matrix);
[COEFF,latent,explained] = pcacov(covariance);
remainnumber=30;
fid=fopen('E:\faceverificatioin\testdata\result.txt','w+');
syms containername;
for num=1:1:numofpics
    for times=1:1:7
        if num<10
            containername=strcat(address,'FERET-','00',num2str(num),'\0',num2str(times),'.tif');
        else if num<100
                containername=strcat(address,'FERET-','0',num2str(num),'\0',num2str(times),'.tif');
            else if num<201
                    containername=strcat(address,'FERET-',num2str(num),'\0',num2str(times),'.tif');
                end
            end
        end
        inputimg=imread(containername);
        inputimg=imresize(inputimg,[length,width]);
        reinputimg=double(reshape(inputimg,1,length*width));
        reinputimg=reinputimg/norm(reinputimg);
        z=(reinputimg-meanX)*COEFF(:,[1:remainnumber]);
        approximateX=z*COEFF(:,[1:remainnumber])'+meanX;
        left=(reinputimg-approximateX)*(reinputimg-approximateX)'
        fprintf(fid,' %f',left);
    end
    fprintf(fid,'\r\n');
end
fclose(fid);
end