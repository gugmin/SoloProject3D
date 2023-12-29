#  3D 개인프로젝트

</br>

## 제작 : 김국민

> Unity로 개발한 타이쿤 장르 게임 프로젝트 입니다.  
> 개인 프로젝트이며, 타이쿤 장르의 기반을 개발한 내용입니다.  
> 배운내용을 위주로 개발하였고, 핵심 내용은 상호작용 입니다.
> 개발 기간은 5일입니다.
> 구현된 내용은 다음과 같습니다.

</br>

## 주요 기능
* 게임 시작 화면
    * 메인 씬으로 이동하는 버튼

* 게임 진행 화면
    * 각각의 오브젝트들을 상호작용하는 모습



## 기능 세부 설명
* 게임 진행 
    * 재료, 돈, 완성품 이렇게 3가지가 존재하고 해당 생성박스를 찾아 상호작용하며
    큰돈을 만드는 게임이다.


##  기술 스택

![Unity](https://img.shields.io/badge/-Unity-%23000000?style=flat-square&logo=Unity)
![C#](https://img.shields.io/badge/-C%23-%7ED321?logo=Csharp&style=flat)



## 구현한 기능


### 게임 시작 화면

![GameStartScene](https://github.com/gugmin/SoloProject3D/assets/149454489/e82c707f-bc48-414f-bc80-7f025764e847)
 

* 게임을 시작하기 전 상황이며 플레이 버튼이 있다.


<br>
### 게임 진행 공통 부분

__상호작용__  

![Interaction](https://github.com/gugmin/SoloProject3D/assets/149454489/fa1bcf6d-6878-43d5-acac-e0c4181f3e3d)
* 상호작용이 가능한 물체에 다가가면 Press E key라는 텍스트가 나온다.

 
 <br/>



### 게임 진행 화면

<br/>

__인게임__

![MainScene](https://github.com/gugmin/SoloProject3D/assets/149454489/c31e1c75-368e-4fc3-8d14-0d2c9830a5f3)

* Start버튼을 누르고 MainScene으로 이동하면 볼 수 있는 초기 상황이다.

![UI](https://github.com/gugmin/SoloProject3D/assets/149454489/a59da04e-ef68-46e1-a47e-322b5eb14383)

* 게임 화면의 상단에 재료, 돈, 완성품 순으로 표시되어 있는 UI를 볼 수 있다.

![Interacting](https://github.com/gugmin/SoloProject3D/assets/149454489/46caa1f8-b605-4f0e-9165-eb01a403c509)

* 상호작용 하는 오브젝트가 생성 박스라면 E key를 누르고 있을 때 UIBar의 게이지가 줄어들고 다 줄어 들었다면 오브젝트의 맞는
아이템을 생성해준다. 

![Item](https://github.com/gugmin/SoloProject3D/assets/149454489/4be3b3ea-b213-4561-85ff-ce872b69ceb7)

* 생성된 아이템을 볼 수 있다.


<br/>

## 구현하지 못한 내용

* 디자인 : 리소스를 구해서 더 완성도 있는 게임을 만들고 싶었지만 시간 분배를 잘 못하여서 추가하지 못했다.
* 기능 : 처음 만들어보는 장르이다 보니 어떤 방식으로 흘러가야하는지 생각하고 설계하는 시간을 너무 많이 써버려서
계획했던 NPC구현등을 하지못하고 SellBox등으로 대체 했다.

<br/>

## 프로젝트 시 일어난 문제와 해결  

### 프로젝트

__문제__:  Update 안에 하나의 UI의 fillAmount값 조정을 n개의 오브젝트에 연결시켜서 조절할 때마다 변화를 볼 수 있는
                 함수를 넣어줬는데 유니티가 인식을 하지못하여서 hierarchy창 최상단에 있는 한개의 오브젝트만
                 fillAmount의 변화를 확인할 수 있었다.

__결과(해결)__:  Update가 아닌 fillAmount값 변동을 주는 부분에서 변화를 볼 수 있는 함수를 사용했더니 해결 됬다.



### GitHub  

__문제__:  Assets의 용량이 무거운걸 추가하다 보니까 깃허브데스크탑에서 커밋할때 오류가 생겨서 커밋이 되지 않았다.
 


__결과(해결)__: 파일을 쪼개서 커밋하면서 어떤 파일에서 걸리는지 체크한뒤 삭제를 했다.

## 프로젝트 소감

 개발 스코프를 잘 짜서 해야 스트레스 안받고 작업에 몰두 할 수 있다는걸 알았습니다.
<br/>


