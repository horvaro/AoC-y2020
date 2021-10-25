﻿using System;
using System.Collections.Generic;

namespace day0x06
{
    class Program
    {
        static void Main(string[] args)
        {
            var rawGroupedAnswers = new List<List<string>>();
            var answerSum = 0;

            // Load answers into groups
            var answers = new List<string>();
            rawGroupedAnswers.Add(answers);
            foreach (var line in INPUT.Split(Environment.NewLine))
            {
                if (!string.IsNullOrWhiteSpace(line))
                {
                    answers.Add(line);
                }
                else
                {
                    answers = new List<string>();
                    rawGroupedAnswers.Add(answers);
                }
            }

            // Part 1, Find sum of yes
            rawGroupedAnswers.ForEach(group => {
                var yesSet = new HashSet<char>();
                group.ForEach(answers => {
                    foreach(var c in answers.ToCharArray())
                    {
                        _ = yesSet.Add(c);
                    }
                });
                answerSum += yesSet.Count;
            });

            Console.WriteLine("--- AOC 2020 [D0x06]");
            Console.WriteLine($"RESULT = {answerSum}");
        }

        #region input
        public static string INPUT = @"bapocnysdr
lpandcmb
bplndca

rgi
ci
i
iv

xdgwtsc
gtcxswd
sdcxtwg

g
j
k

drcmwzh
aostudi

qziunh
hgkaslmyz

fovlpdhurzqsway
zvciokytxbaf

y
y
yp
y
y

gqouslwfihtxvke
bapdmyncjzr

ywirnpmozqle
jhapfdzuvgc

ce
evn
yzsem

phdcuxgtosjier
jfixnurtyopdh

mxjs
mxkjis
jxsm
xvmbsj
sxjcmh

sgrbtmqxpwkacnzd
brncqxtskawgpzdm
mxqjtcpzbswgrnka

fxijprlkbhte
herpxfbikmtlj

ltuyidqkcrevanw
whbqavirludxtye
vfirqwmsaopyzld

q
q
q

faxhswigtprou
xhlusnijytkrwza
xaqsburiftwh
rtahxwcsiu

cuplrimdtxke
letpjuimzrvkcyx
cpleiuxdktmar
wrfgkubeoqxsihpntmc

zpbjimulvrdwxsog
hfmspnuokbxe

ctm
ctm
mct

tvkocqebls
qcnbktsveo
fnvkbscqyeot
mbcsoevkthqj

tyjgd
tydjg
tgdyj
dtgyj

xgiybeuhtkfdonq
diuqvfycrokhgxbt
igfdbhpqklxuyntjo
zxqkymfohstuiwdgb
kgoutiyhfxqcbd

wzfiaexksp
fizxyskw

azsqntcghjmio
mgksdwpcitvxqjr

ctwzu
jwctuzes

bpymqfisrvtuheljwadx
iejsubvxhdmwpqgfrltya
jbxmfshuvyegwqlpridta
vpxbwlqumetdrijhfnays

w
i
i
i
i

fctbvjmnroypuxhlakzw
cbpnmyzrtjuavfohkxlw
znoptxwakjfucmhrlvy
nkmlrhygxcazowtpquvjf

ibanduczjfmpt
gqimbtadcuoszjfprl
mtaizxcdjpbfu
mjfaiubcdzpt

kdxav
maxvudr
adxv
qxavdi

uajvepgoxhwsqkym
hwesxqvpuzgb

lp
pl
pl
lp

tawk
suwtc
stw
ixltp
wto

phrawmes
bscrhki

xhwurk
hwea
bhwe

tuhvebm
bemtuhv

prziuqhcye
qipyrhezcu
ueqzyprhci
yurseihcqpz

mnfotvpzdxbaglye
nbjlomxzacfqgey
glxhuwoskyrabi

tohbrluismcagnypqdv
duqbhylatcvosnprimg
qtpbduycrlosngivhma
nvgucpayidlhsomrbqt

grslqxjdytzficnuo
klarqjpxfscgyouzi

qozstka
pjnruvic
fchup

yjautz
ajue
vlufjx
ujy

inythxv
bhxvytin
htlnxviy

mhcqvt
sqtvchm
htqmvc

vswymdnahrq
hrnqvysawmd
ndsmqvwyrah
mraywhsvndq

jtxayp
atjxp
jpraxgt
jatpx
adbwpjltx

vbni
ivgfn
avyqtmsikn
nhwivrf

fkygvtsbpazdjwxrmqoi
btyfwsvpdiarjqoxmg
wvqyiaprsmftgxdojb

a
a
an

pynvsfcbherzqiwumjaod
dsivqjmurcfnzebyhopaw
mqsvnueoihczyrfdwpbja
gjqsaiwdczpvublmnokfryeh

drawsthnfvzylebo
jmkzqhbgicxsu

pg
hdob
nq

gdbxpwmtvhoaely
omvdgatwbxlpyeh
gtbyxrvwmhladpeo

ugowlqebtcpdxz
wzobutlqgdxep
tulbvxwfadjpogqze
qubdxgztpknolwe
epztwlbxqgodu

rsvebtycq
becltsrnvw

tgsljhz
zhltjs
hsjltxz

daguc
fbpudxyg
glidjuo
goadus
udjgaz

qkpwetasjfbdvh
glixc

pufekjh
xegpq
poewviyn
enlbvp
tpesm

zqfiwx
zqfriw
wfzxil
zwxu
dznwktpb

kcaomdbszyi
ildpzaqsbx
xsdqirazb

mqebolfk
peqmgf
deqfmw

grcqpi
dvpmqte
ohlwfujxkanbsyz

txnhgzuwaicrfl
qtnwizslxuahocgr
mcxhglnibardwtkuz

cvjbyrewa
wczb
zbwc
wcb

psvotmiaqyuhdnrekw
aovnrqwsiyjmdutpehx
gaephqunbrwdsmyiltov
rmftshdpcznwiyuoaveq
pyatoimwhxeusnvrqd

wsjvydieaurhqxofzlgpmbk
kemhzfusnpajxirywlo

ypiz
ipz
jwiz
iz

pxoedfk
pxogkd
tkjsdocpex

lsoz
zxc
z
wkz
zpw

frmcndwyeix
qritwfuymc
mzrwyfixc
mfczprywi

ygvtslukaeoinhwd
vnepzqmcwyjlufrdobk

bi
itb
bi

wy
qomwberkixc
gw
hswg
lpw

krifxwcusnjmle
cnijrwxkmspf
cnrfiegmqswkxjh
skiyrmwxcdzjnf

ifwqlzhrudsmn
fzblomnwspjvk

vnjsxdiobeuhcgfw
dhwienfjsobgcvux
wsinxchtegujbdvof
cioehdxvnjgwbusf
gdcsfeobjrunhxwviy

lpzntyhsxruiqjckwv
ixyprghzqfvjsuotlw
ayltehsxubqpmwrdjivz

r
lmb

n
n
n
k

lfsxwgkeioztnuydmqbc
wkosmqcxtdnluebigyfz
olekfdcyxgqtsbumzwin
kwqzfedxblcitgmnuoys
ibdetugcmfzoknwlxsyq

c
c
c
c

nmrohgpcwsjadkyqzl
mgjhdwcpoknsqyazr
chnajzmwopkgdyrqs
bdcnhgamkjqysropfzw

yqtid
ujgkz
rmas
jk
og

f
crj
cyo
neqhmb
f

uwxc
wpcu

bkhpcqyeljvftxnz
kpvxqcjin

eqjzkctynvo
qyovecnjgkt
xjckqenybvhpto
jnkmezvyctqo

lon
w
vwh
h

zrosv
oblzfats
cuozbmak
dpyegwhnjz
oztiqx

bvlwgjrixaskqpuzyonth
hatusdrovjgwcyipeqkmzln

vhneajldr
apnvjderl
lynrjcae

qodczyfijam
fkdxpgrcnmio

oai
iao
oia
oai
ioa

nhgewpbozmjascrk
vsocxumhryfnbqwkaj

jxrls
sycjpwr
bdcrqenuhtsz
sravkif

bymwecxqrloj
lhofkz
vzldo
klof
oulk

lfxobdwcji
odbpnilxjcw

pbcr
rcpb

msp
esm
sm
psm
dcsm

clkiabts
hskec
sckgf
kfncs
sekc

dyckmholpqbtaunf
lacdqknfhuymtopb
kntfqadpjlbcyhumo
qoflmbpdhauykctn
dphmolaynqcfbtku

whkzitxfqem
ftixzqmrwek
mitabqyxkzjwfpne
qzwekxtmfi
iztmkfwxeqd

wxktrn
txr

tapvryqbecdklwsjzxug
mwjgatucpvydsnqbklxr

tw
wt
wt

irsehx
ehsxri
rhxise

ekwyuzsvpfjg
lcspakbhnmiod

qifdbzapc
rwpvkbd

f
f
f
f
f

yskpcdmber
bnpdelmcryksu
eqcbzdpkgyrmsixj

ibt
iez
cz
b
xvls

d
d
d
d
dq

ubfpqyrkhceo
yfhqckubre

zyhnmseuivlbxgfk
nviufhobsyelxzkm

agbdzfsqetclpw
wctbfaqeszpgdl
csbtraldqepvgzfiw

dmatzvowqcklbgirf
ldiczavboqgwmfktr
gkaditvmclqrwfboz
dvrfntlcijagmzobuqkw
iwzrtblvdoamqkfcg

xhjydaekowcgsmruftbpqvln
wzryxjmfdloqvskubanh

skglcvahyx
xyp
yx

tvsguaxobzkd
txoguzsmkbv
soegkitjbxyuzv
kvobgsztux
gtxvcspoukqfhznb

osca
osai

sjv
sjv
vusofja
vjs
sjv

ipwxnmkbzhscarlejtdoufqyg
ujlxyqzkgtpfrdnihwaomscbe
dyslimrkjqxnftcpbewzuohga
gyphacbxnqdriweumloszjktf
czbroamputiwjdnqhleyksgxf

dygktjflepbcqm
zfwsneviuo

usz
usez
usz
zscu

jkbies
ejikm
ejphkoi
kmjseiz
jike

qwjvbzmypcif
hveligmbpatow

aumeftxligdy
tylfgicdx
wlditgfyx
tcxdgrilfsy

wi
iw
iw
iw
wi

zsd
cbmoz
ouwbaq
ghexrpyf
asmz

ax
w
wrd
vqclmnjfob

sy
aumz
azs
hvoecbdfgq

p
p
p
po
p

sydzgpwourlbqfcj
mnzcjkeubaprofg

kiatxsph
iphktsa
waplhikjt
thapik

cpv
pcve
vpc
lmtcv

eyghlrunfctbqzos
nsryfzuqtmecol

zayxpivkctudsmgrhqfl
ynfsuctxhakdpjglmovq
fdvgeskyaublpmhctrwqx

egymspiuwoarnlj
poidtzjyglwume

tmlv
motv
mvthn

vh
vh
vh
vh
vh

vthobzjux
ojutxvhbz
vxhojbzut
zhtvbxouj

k
k
e
k

bkwvlpt
xormzn

aforqletdymv
eyorqmflvdta
ytvaqoejmdlrf

rqakhn
khrqusmaj
rkhqa

bmyztkxldgiosnw
tsoyzwixdmlbnkg
btimzdlywknsgxo

mqifeszchaoxjygvdrklubwn
zjdhxnboagfrc
cgarozjxdnbfph
xbnrhcjzfgaod
fzdhrxtancjobg

gzdvh
gztvmch
zgdhv
ghzv

yjldgioabsr
musahntecwl

fujnlstvgcbwio
clgkwmijsupqzbo

cqi
iqga
qza
elgyxq
dujqtkprvf

dzrawsxvhgtflnjeikoubqypm
pryqevnbkiusghjlofadztxw
eawipgrutyohqvsbcknjzfxld
bavdzsphqugykftnjeorilxw

q
vxoln
feq

y
s
s
l

gfdp
pgd
aep
pdfsb

watcn
tawn

l
nly
loy
gwsvl
l

ehfqltbkvizcmpaxn
vzqkecthbmnfxliap

l
lrx
l
el

mznoqpxfvedutclhar
gsibywkj

gft
dqs
rm
rbe
dnsrh

dgwncrbfo
uboewdjnagxcr
ogrcdbnyw
bwgrdnoc
orwbcgnd

xlnyqidbvfuopwsmetkaz
axsnipqkotbydfvuzle
zsyaohudvqweikfpljxnbt
aezfhxqipvkdtbnoyuwsl
qsneybxfzidcagokulptv

phnrogdiuwlqtmfvjcb
sdmufyklricxpg
ifdxpmkruealgzc

xdiushclzbkvnfw
bjmzunysickrfvxd
xciutvyksbldfzn
xfqpzabiuecnogsvkd

olv
ovl
lov
ovl

jirywmg
jnxmg
jfbgm
mjhg

sjfvbhimpyauqctgx
xasifmnuqtyvgwojclp
jxyqabfuismptgcv

spgmtcvwlxyfaq
gpnqlctymxw

xthqemkfpyls
pqhtsymrgzoef
yskhmtfpqe

xcsqaokhpt
hcopsqtxak
pqoaxstchk

oqexlariumftkcg
xceqoumklaiwnhtf
xekitmlufoqcag

zkjmutfxryowbnv
euomntlvzxiqydrgwspa
whcyrmvozxktun

hxqncgbjrsl
bnlxcjrqhs
cjqngsblxhr
ihpsnrblcxqj

rjtlufdmxiqkn
afmrkuindxljt
uktrmjilxnfd

ypxqris
hpgk
budwp

oqulm
u
u
iu

kahocwxnueyri
rzesvkxyltmbpqg

pkxjboidfvymngzrts
rsizgmydxkpfvbtnjo
bopgismxvrzntydfjk
ovgfdztnspyxibkrmj
oecxdvmgrfkzbnypijts

ruvmcpojzsqtayw
rqotdwzmpjcuys
ptnscirkowujyzqfm
ocszmjwrtyqpu

nzxqdbwvpkioaj
bqijkzpxwonadv
kivqoujwxdzpntab
inxabjvzpqdkow

ochlv
covl
covyl

qsoypnvewrhjkdgtb
jpgwdknqeytbhsovr
bdpwyrjuhoqgevtsnk
rkoeypwbvgjnhsqdt
qgtnyodrepsvkbwjh

u
i
o
o
rx

ecikgqxbyjhupozvdnrstawfm
cnuiyopkzwmsbtadgeqrfxvj
omkbnwrszvaetclqdpxfiygju
wimrdtexbnjspgokuvzaqcyf
veacgjpzmnioqksfwybxurdt

egfkhxi
gkshf

shiayxrwutmzf
isyatmhuzf

tfgmicrqnpxz
jeurkptlyh
kvtphwr

tyqrx
hotsrdyqz
yptqr
tyqr
ryxtq

lxtdzqwcakvm
xdkqrlzv

ipujabzkmldhfrwg
bjmpkavhlgqrwfdiz
ofhizbrtdcagljwmp
bfgvdaesjpwrlzumhi

s
s
s
s
hs

nobqduvlcjtw
dyrbtpzwng

iohlwxgfs
zokfn

uawlqejvnfkzhor
rqhkanfvexlwzoju
avqekulojnfrzwh
kljwrhonqfzauev

ln
nl
nl
ln
ln

qyxi
fmxbo
qxo
pkvnutje

tjsz
zjr
gydfxcjliq

ufa
dohwy
f
kau

ezjqncv
jqvzenc

pnhlasjrztw
rlswpatnjz
hpntrjslazw
zjnrwtlapcs

i
i
i
i
i

aovitgfucj
bowihz
iol
iweoz
iyo

bdgmouhjvyxr
inpshdz
nhdfia
htdl

pnzawmosg
zganost

emrakn
glveamkr
rkgames
akfqmper
imudroeak

tibgokrjpxmy
iydtpmjkx
dkcjpxseiymt

imfnqegj
mcp
nwgkhmbrpjac
szovdtxl

qnosfwmzpiubkxdhctg
msutibqnakhgczfopxw
xtnowmgicfqsuzbhkp
pwbkcqiutxfshzngmo

jgaqubtpokrn
jpqgotluzna

siblotrefupcmyajdwxhvn
tdxpnfrbuivjchlsawoeym

gvbfkphuqwsrdoejlt
ixpkoqzldfncbahwt

rdlfmyaejnswgopv
ysjfvmazeilonurbpwx
jayvlrwcmpefnos
yowvefjknltqamscprh

r
d
d
d
d

iry
gi
lri

kzopchbqgf
phcifmsbgz
canbyhlvdfpg

ljmtd
stlxdvmkjqy
otcljbfehmd

zgkiqsjrm
rmqosfenz
zqdmrsig

jaegcxl
delcpxa
lktzbxcea
pdclajxe

gdrfnb
dngbqriyh
ojnbgrzd
fdnrbg

ixnhlufgkqojyrcdwms
uvfmspygeizlkhxcawrbdotq

cfzy
zfcy
czfy

kfbqdvgacxnluszhejiowmytr
durgtzlkjpwnechqibxfamvoys

njcgoslbyutihpqxwe
wrbgpdquiykhnofvecztl

cozxyqbvugrmkdwlh
rxcdwuylztbvgmqhk
urmhkcdlxvgyqzbw

okzsvutdehimnc
mednkuhxgqwvizots

sogfalbukwvchqmjdtypzix
pyfazktchbmvsqguojwxild
imsgakcotjpdhuwbfyzxlqv

yzpafqijdchrvosxkt
tqvsdrxzojhipfkyc
tsfqokvphixzdcryj
pjfqzhtxocrdkvyis

ysmndq
qdsnm
rskilmn

q
q
q
q

fygruq
fxckylwohur
fspaznjvbmdt

ztqa
a
nma
a
a

erml
ejrm
rem
emr

qkmpeuatxdbrcghnjlo
xnlmcohutkdbeaqvpfrj
rboxcdpaujeqhknmtl

bpmiwjrs

tyr
ry

jkyolgr
dv
anwid
idzv

z
xzpnb
z
z
hz

mwxibru
dxrwzobi
wixqvrb
sbrxwi
baixrw

yzcdlgujxrpmbs
iadjzpcnyrm

nq
qn

sbwtamevgyicuhxrlfz
uzxkpmitwvlfqhcgjn

xvhbkanc
bozyjftqrl

vpcougdijwlxtsmznarqfy
qyroagjdmsicwlftvxunpz
nylpitxuqdwrszamfgjcvo
amogspxyvrdniztqfuwlcj
fuoiwmpvtlxdszqncrjayg

ocmqey
yqoce

mvulfyk
fxyuivlmk
afvulokym
xufvjmykl

wjz
owpfqnsrgt
ewycah
webhjid
bwi

ucxqaszovj
xacvqjskizuo

auxsjhkiq
zcymv

qyljukpbitdx
pxqjlduitkyb
utbpqxjyklid
yjkdqxptbluir
puliqbtkdjxy

ljurghymqktvpenzsbofwdxc
ofyrjptgnczlwebdxvqmkuhs
blopcvezhdsjnxgyktqfmrwu
dwmqkuhtjsofnzgbrvelxcpy

zn
ndz
tzn
nkdz
nzvk

vmyrlzxcwkjp
mkqlvyrcp

xduvzyfarpkewscjqlmh
fzcyvxkmhwqreapds

nt
cs
c

jxraviqybmgutesdwkfohlp
hnkfweosqvbijpymuxdtalrg

fcjz
mnwvo

mfqnkiaj
nakqfimj
arikjubnmqf
zfqikanjxm

pjetdfwsxohlz
wpkzntbfsdcai

zoifjgyxkluhbrtq
yjolrgquihbnxktfz
zoibyqghrjxtkufl
iuklgxbyrtmjfqhovz

r
r
r

ytqzlvcwseb
bcvqntlswyez
cvqbtewyszl

hfyj
jsbrzyhiwknfg
vfyajhd
djfhlym
fohyjux

dzcjlgutfoipaexkmn
koetcadiuznpmljf
ctnilkamodfpzjue
cofuezanjlpktdim

nvtjmurwhfzex
thxnrwmvuejaz
jexztumwrhnv

r
r
r
a

enoclavqmypruwkb
tzspyhlawuimvrq

yxcbvjpsgt
crxgvitlzjbop
gukcdbjtwvexp
bgjcmqspztoxv

w
w
w
w
w

qmocdhri
qpwioderm
dvmocjruiq

nvghcjxd
nbcvdp
nvhcd
djcvn

yfzukw
kuywf
kwsyu

adjzmqebokxhtuspwgiynf
fmshwkpoguljtyrziabqn
anyofkgzsbvpuiqthwmj
qfbhkytzgnwoicjsapmu

tlmn
nlti
tyehjn

s
r
s
s
s

n
u
u

tie
jet
et

achjyurqb
jpcbrhutqy
rbjyuhcqp
ybfucqjhrw
qujrhbcy

o
o
i

migypa
pyimag
pmgiya
agypim
yaimgp

kdzafylcnst
aznrtshxgylcb
cstzyaln
anetplcsyzq

hilubmsyznrtvqxpjo
yqbirxnpzslojvtumh
tyxlnibhzmsovrjqup

zloiuyekfpx
aqtxzmig
wsgxinqbzj
bavthrdxsiz

acwdny
ghrxysndq
ovdncy

p
glxy

ksnzbjyxgwtvm
nbwzvtkjysgxemro
bvnykztsxjwcmg
qyzbmxjhtakgnwfdvs
xzjmbsevgwytnklo

uolyhfmwcpnk
ykuchfolpnwm
lnckhofpyumw
ylnfuowmrcphk

oumqj
ulzybvfsp
um
u

zh
gh
zh
hns
hg

xlvaqwncsizrbopukyegdmh
lxmsgzqyothupikvrbn

lhqdviu
qafnemdvlzbrpk
qlvyxdw
sdluoqygv

v
v
v
v
v

blqcsyup
clmpubs

noumlji
nouji

wkvj
d
ghy
x
k

ohbjykuena
jbyahkpez
jyafhevbk
yeajhkb

auqjksywpcthxf
zchkqmanpd
kvaephqcn

ygrvwtleidhapqcoxjzkbm
uvmtjkcxphybegzqrawiold
dpckejybntqgvhzaomwixlr

wuvknho
wunhkv
awhuixnkv

xtsglwhpkozumein
tiwzoklpxheumsgn

kdicmfpsejygzlraqh
rgpqkamdfecyiljzs
fgjrczaedymqliksp
adlgcpfieqrmsyjzk
mfwincakdjelorbygqszp

jhtufzbolnrpgiv
rymwi

bcdfkrgujzqwheptivls
wlzfyvtimksqcdujngorb

eruyigjwb
wojeybiulrg
ygujbwvzei

fizsg
jnue

yalxikzg
iagxkz
xizkga
zikaxg
ikxzag

pjzlhqwixksnovbtygr
ljnvgzykoswbtrhm
rjtnogykswczhlbv
ychwztvrgsonebaljk

wcmyzldhtfrposgnj
fcrmtyphngjlzs
gpalbicyvfnmjxekrz

ysmpe
yemps
stype

meruv
mbrse
ryvmsei
laremdjq
bremck

jaeutopnmdhvfklscirqgx
selpyhdginkxfouq
difgepshqlukonx

oyz
yoz
yoz
yoz

kohdfzpsj
rjkphfdzog
jopfsukhbdz

cpvr
cvy

xavdpsto
bweoysidhp
rndplvsukoca
odgusp

ofzgbwqdnkjp
vcbnlqwofisg
enbrymdqpogjwf

ukrdtiphflv
fvdlnuirtkh

s
s
s
ms
s

smodvglcpenzbtw
vgwcmfdnlobi
dobmzclwvng
convbglwdim
wrcojghvdblnmx

euy
iey
hrkyowpesz
qeuyn
ylfe

jd
ygd
d
d

ifxlcevjr
muqybvdntl

hpjdqw
wjcmqdp
pkojqud
djpqm

fz
z
z
auzlgh
zf

oadfixtrspzymgkjvhc
kureodwxjzvqcagmflt

umdbplaejicognthw
mldwpqitgubajnecho
gdrhabsmketcwpolunij

utpjbioagl
pujgaobsti

wzqkmfigsenp
btdpmnrhaix

g
h
fmy

qfdshywubmn
asnjyumvhfepqwbd

tko
k
ki
k
kvj

ajrftpclemziyx
tyfcpmzxjrael
rlymxejactzpf
xpfzalrmjteyc

lngatvoimxerfs
xvsyefntoli
ixvdqstzlonbefk

dytmarichvj
tvhdurymj
mefohydrtjpvx
yajumrtvhd
mjrvthdy

mdizkcbhuqxfpew
lciqkhpdzwumfxbe
dmwbhzqpojuexikcf

av
a
a
a
a

buwiq
wbqi
bqviw
wbjifuq

szyogteivkjmubnl
gnmeioyhdjzkutvwqb

vetwlrjnzuxfamsydoqbhpcigk
lhagxseotdcqbyrwnpfkizmjvu

ikt
sxuik
rigbk

ixzofbapunser
umbfxasovni
oansfubxi
xsoauibnfk

ebzhanm
rsywcgfuaoqxjvz

dygrvauxpemhosqkwtfji
pxafqktysdjvgriwuehom
ikurtagpdqswmfjvhyxeo
mhqlyugsravkxoptdwzfjei
wejrsutgikxqpfvydhaom

ynam
ny
nys

exwzkcjqnvp
ekpzvqxjwacn
wqnjveazxpkc
zjvbqkwcrnepx
ecnvywqzjsxkp

qmfe
qmep

dlwymbrsvgxefi
gxeyfiqmr

mjgkdnbqzcrtfvue
ujgvnrtedqkzfobmc
nerkmbcuztivgfdpjqy
bktnacmqvjredfuzg
jgdecrktqnbvmufz

desyfjcwkgpabomrxluq
uecwxsrgybalkpqofjm
gmlaojpwqxsebufrcyk
sxfoakcyjlmrghqepwub
gmwouepvzjsirxaylfqbkc

lugbrcezj
ekzuhpxtl

bzurvkdm
gkzbdvmuwq

vihtwalesoqmgzrfub
dqogrhlvueimaszbtw
lmbiwygzaenursotvhq

fagwlnujrsv
ujhnvmcrpsqwl

dsoq
odzqs
oxehvgqunspa
smoqd
dsroq

lw
qnlwbze

zcs
dpalw
oqevmritxf

hw
wh
mhz
h

xwpkgiureobdvamtlcs
sumvltgxoerdpwbacki
faozilpxetcbvwnsrkugdm
dioulrkpawstcbxgevm

cfziqrvtghejx
zahecstbvjrqy
gcqrzvjnteolfhd

jronwks
kjwrso

xtfp
aqwzv

gjvrecbxaqns
koficxqpjsvnalzb
vcjbqxtunsa
bvjxnqcas

n
n
k
if

hnzquyjxadotim
ctrmnlvfugjkoziqy
ubnfoyqctmzpij
gyqzvjwimunot
nzmoluqikjywt

wykxduqrzl
drklx

xdr
xrd

sdrbokn
rsnbdkio

qespuyziargjdlwnkbv
iaorexbukcmtnwhf

gti
dit
itb

tzmwbguraxjcieodnf
gmitqzdsnekjoxaf

kdeziwsnf
lgzkiwen

fbvikdpshltegu
kpfvidlguehtsb
gdysepktuihlvfb

jzegrfyducaospkltvwq
crzgkleptvuwsfyoqjda
rogqtajuweylsdfkzcpv
zwacrlsptgqfoveydukj
ufokdrzglqjcewtaypvs

hsqnofzvt
ahvpn

umaznoshrwf
hzosundfr
ushfnzor

w
ie

byandqklvw
wadvyxbqikn

xspcwfvnkuoydagthjmzbq
ahnprtxeojdmgfqvwzuikscyb

txpwbvjacrzifgshyluo
hgytapvojfsbrxwilcuz
wpvxzshcrabfjtygliou
bvourjgzfytpiwchlaxs

ufesbdavpn
siunvefpdab
nspafhdvbue
vednpusafb
sufvpbande

lnzxudorwykfqs
vckufbqxhwjmtga

twz
twz
twz
tzw
zwt

nuaeqphyvo
ovaqetnphu
wvhulnpsxroqi
ntvqephou
hyvuqpon

szky
kz
kz
kz
kz

uekpcxjqrbzy
ewiyrkobtl

rghuyp
ntyzexi
yjnq
sy
eysao

yohactxlqbvsfe
yacfqtxlsvbeho
qxtaesbfhlovyc
ybotxfqschvela
tsxbqlcyvfohea

crvkbef
efbvkc
erfvbkc
fvbikec
ecvfkb

eziafud
odfeiz
feizd
rmeflzidc
zeifdo

uh
u
u
u

slzwuvhqnbpogia
bhviznawou
ufazbvinhwo
ariwbuvzhon
vawnobztduhif

lyi
syi
imy

igx
qfz

yugfqtepvxwdocijlzmhka
ymdleizpjgxcvtfhoakuwq
utenhymdcgjqzlorxfvakiwp
zwlvymtgfxeqcopuahjkdi
auzpqtcifejhomdklyvwgx

xfvdiwqpktjlaborgez
mlcubagjpwzynxekqfiotd
fadoezjwqxtpgbkli
osldxpzbqeifajtkgw

mfxjtn
pqesvmxf
xmbojhft
xbmafc
acbfxhm

bsua
uasb

dtmpiwjkuahzryfvqgx
iavzqyhgmrxwtdukjp
thzkaxwjpydqmviurg

uabgmyoidlekzcqnfvxsrw
kcybroagdmufqxiseznvl
eroscxuqvglanbikzyfdm
gfmdeibnkvuaqryzloxcs

wtmds
cxm
wqdrmz
voahgpkfml

qmougypvzh
yoqsgdpnmhuz
gauxyzpkoqmjbwfl
qguzoivyrdmpt

uyerotgj
wqszinpyv

rosx
ors
ors
osr

dtcuiwlse
bgaosqntxuwfpvrc
uymskctjwz

cshbnzoduxlpfrayj
hcasypofnrxblduj
pjyuoxrfbsaldhnc
uharfpoxcdysbnlj

bsklgcdmpxio
ojbpdlcmtugskx
exdkmpboclgy
aipogmwxdkrclb
dilmqcpkxnwbgo

xsajoug
pxujgatso
guxojsa
mbxuwzjosga
pxjsugoa

tgfw
xemdgvyfu
jfga
lfg

khvg
kghv
vghk
ghkv
vgkh

xfogcwnvkey
kvxwomyfeqc
woxycvafkbe
yovafwxcke
ekvfyxnwco

ezpfkoxycuwgimqvabdtjnsrh
nmpoxgwdyruecazsfjbhqktiv
qtjzmaycsgnibdxeuwrfkhvop
yfaqredhbxinsvucogwtkmpzjl

mhlnsrfadjpekczwquvo
vsdneluworhbqjfztamcp
smthfdwjznvqpclogaure
cevkfuzqxjmwrlasphnod
ijrnwqpvudzalfoesmch

icmdtnrpq
tmdqnirp
mdintrqp
rtpmniqd

clspvk
xclpsw

rmdoajtxvc
vurmjotdsa
mdrovatj
nadvmrjlot
drjotavm

kl
hfjkblv
cklr
lrsk
glk

xpoawenkc
yrkpnzjocxue
pskncodex

b
b
bq
bh
b

kngbuqcyijvxeh
kbcmngjshaxiyve
enybjkvqtucgixh
zhrevfodplyxnwikjgbc

vizojfmup
mfzhjqpuoiv
uvtmfzipjgol

ysobmzkthjdw
qlncxwamrtujevfpzgbhkdo

gz
gd
ickxr

brenfplc
rzpvwumik
rjctp

hfwcruyoa
ihyduxfw

zlumthynfkjixo
kgxnbhztfyojmli
kifzxhtlymngoj

rqpdbzgjsowakvt
gdzoyhjetcfbqkl
nbjgqftozkud
zxbogjqktd

writbe
etri
dtfkern

ctwyqdi
j
me
nkgzau
sxkare

qlwakzuxsnfjc
ufzkhmwax

njuysxmhdzivfgqb
uamlqxdhnyvgjibfz

eigl
lige
elig
geli
legi

vrmhebiqupxoclfatdkg
ytaoiknwcgrsdzevxj

rhac
dcajbr
oxizsuykfvlwn

a
na
a
nka
zdua

zedtlhmj
yqoxn

wyqhegrp
wypqhegdr
unrypgwqhez
hypqrgbwe
yrgpeqhw

mxjkhbqgwuniftedzvcl
jciqfnbeumlkhgtvzxwd
njwquxidvbhctzmklefg
hqfwtcmkuxvbjdelgzni

lsigyrmjndapwtehux
mtwpirehgfxuasdjnoly
hpdlgjnimeusbtyawxr
agywjlsmktzihxuceprdn
njwhigapyexmdlutvrsb

wiaejbsdzncytol
cjelwafyindtbzos
zalobneisywctdj

jbsipuwdcyth
thbauysdcgpiw

bw
b
o
lr

ojkmnthfzlvg
vhpzmgtonw
yjovmnfwthz
fnzhtmoav
zcosivnmhdetx

hdkofir
kanxoflugziyd
kodfcrwi

qxpmckuelwtarij
spxmvqwjrileckuat
tuiqrajpwlmekxc
taeupwljxricqmk

dn
dn
nd
pnd

fvyxadu
fwxmny

vsxgc
vscxg
scgvx

wovudbian
dyeosauvinbw
auvdwinbyo
uaxoqnwirbvzc

aosvcdn
osna
sano

shqt
sqth

ktlracvqpeju
tukcwearql
trealcukq

rsezcvdbal
zebvamcdrp
cbedrvafxzn
vxnibedzrac
dbirvczae

gbpzy
ubglkzp
pbgz

jtxhnfge
xgfhevjtwn
tjhngfxe

pvodec
goedfvamlx
eyovd
evdorpn
vedot

lsyqpjuviohbz
luzjybidopvx
yiplobzvj
zobwtpjlvnyi
bzoilvpjyu

cevybwgdmuahsqzp
ucpnimw
owunkcpm
pmwoucf

uqchtxvoaze
ehocxtvza
cetazvhxo
ztvxcaeoh

cgsonqxtdfwhzymv
qbkncfmuxapdwl
mfxjztcwryqdne

zbkyrc
ckrzb
crkzb
zkbrc

mca
cam
mca
cafm

z
z
z
z

zytoupbkxdhmgcsflweai
smpikvyzcxlawobhefudgjnt
dolpihwzxqckmaufytgbse

ktsr
ktfs
itsxvkb

n
i
aklsuty

wkgtem
mewgtk
gkemwt
emwgtokb

mbuxkiycz
fhronqjexplgwa

hu
emlw

vkuwrqnj
hys
mzet

fmclnjvsaexpkg
zjwpxevkmacsglf
xsamjlvkcenfgp
vapjkcmglxefs

legmbjuqsdkihtv
dlsqkegihbcjtvm
hqgdmvljsrktebi
ehlbvgidqtjkms
btmshvdikljgqe

k
kr
lfi

obmup
ubm

azqdrvjimbfnoyp
zbejcqxfkotplndv
pbojdfsnzvuwq
gjpounhvqdfsbrz

minxopwrsbvqegyuajcdth
oahnukmgepbtdriscxwvyj
xmbtcwgrasnozhdjiupeyv

jitgzlokacv
vzkushynclojtxgep

ntj
ntj
tjn
jtn
jnt

gdzxykoialsqurtj
kigupewoxqjaztcdy
zugyaqksiojtxd
hyjqxgzdauktio
kygqutaszdbxjoi

orsfkumexiq
rsbjepxmi
smrxqgeik
arnsetyiomxv
mwighaxsdrce

mcuzkqvsdpltxe
pklvsuexmgqwizd
zdqxseckmtyvlwgrp
dvslkezanoqxmpb

tcbqprkjgnihzs
ivgmxyzaernhwcqdjlt
otqhfjgcunsrzpi

omqbwvktlsxjcfzaphyeid
zijtkyxhqvowpulmbgenrdca

igrz
irzg
rzgi

kefw
kewa
akew
xtekw
ewkf

lvxahjydcer
sobnzgkp
musqfg

orijnpvwm
obqzv
ulvo
ozuvt
zcbolkqv

ouzpgsxejbmqkat
btiuxyojspgzqalrek
ekbqupzaxfotjgvs

t
tb
t

ksyegbpm
slmpgdetzbk
gbseumpyxk
ekvphnbcjgms
wgqrmispobkefa

gwexf
wfxeg
xwfeg
gfewhxb

oephijmkngbxw
kxobwjhiegpm
wehixbgkjmop

rmvtujdxhki
lkunxhme
mafxsbhuogkypw

rpimb
prbi
ipbr
brpi
ribp

hvjdeyw
jhecqpbyvsdw
wvhdjye
wvjedhy

uodmbcpvr
wvhk

j
j
j
j

crzngwqm
zqgrwnc
rcgnwqz

xstoyzgvaefqclbuhi
ywbmiguzthefkvqo
pcuezdviyoqfbjght
ubigqfztyohve
zovpgfueibjtqsyh

qatefihbypn
xwvskd";
        #endregion
    }
}
