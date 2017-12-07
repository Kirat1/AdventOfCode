using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Day7
    {
        //        public static void Main(string[] args)
        //        {

        //            string[][] input = {new string[] { "czlmv" }, new string[] { "fiwbd" }, new string[] { "twxnswy" }, new string[] { "dhrnu" }, new string[] { "yptrqp" }, new string[] { "vikplll" }, new string[] { "lgxjcy", "vsbfmt", "kbdcl" }, new string[] { "tvisu" }, new string[] { "imxraee" }, new string[] { "qfbqiv", "gwlyvbx", "uanby" }, new string[] { "eolilw" }, new string[] { "gywnt" }, new string[] { "dnybu" }, new string[] { "yiyhuxk" }, new string[] { "axrep" }, new string[] { "ajtjym" }, new string[] { "zjmhab" }, new string[] { "xcstcy", "iequdmw", "fozfiqf", "ytkmda", "ywawq", "nfgmyd", "bzumy" }, new string[] { "dgscbm" }, new string[] { "sghuxq" }, new string[] { "jfmuzo", "istoj", "jyzrmnp" }, new string[] { "zjklq" }, new string[] { "zwcucws", "vqghe", "alycm" }, new string[] { "ldfhqjw", "wpprys", "heotf", "dybitt" }, new string[] { "ckbjuyy", "ygvwdmg", "pwxorqj", "hshbiaq", "oxqvzzv" }, new string[] { "xnalv" }, new string[] { "owkily", "cqnmo", "fhqah" }, new string[] { "wrbknnc" }, new string[] { "imakkq" }, new string[] { "iymrfq", "iwdjjf", "zamje", "eduxyw" }, new string[] { "umzsfe" }, new string[] { "ruvmsg" }, new string[] { "ewtdu" }, new string[] { "uwcqi", "umzsfe", "tqjzv" }, new string[] { "nqqxz", "jrkbh", "hyyeb", "abwmmuw" }, new string[] { "metyk", "euriiux", "zztvgwh" }, new string[] { "smxwnsk" }, new string[] { "xhodzi" }, new string[] { "unscz", "dpavyu", "lrdmltp" }, new string[] { "yrluhjr", "qdpcslx", "echdbt", "aeeas", "uodyv" }, new string[] { "vvqtv" }, new string[] { "sigxauh", "dnybu", "kpnbj" }, new string[] { "nqjmi" }, new string[] { "rsocykv" }, new string[] { "vqghe" }, new string[] { "lumomlj" }, new string[] { "ewods" }, new string[] { "qggycuv" }, new string[] { "zqbtgtw", "ewtdu", "xpmpulq", "kpnjmwz" }, new string[] { "qnbnflf" }, new string[] { "aintn" }, new string[] { "ibnho" }, new string[] { "vsbfmt" }, new string[] { "zwake" }, new string[] { "swpvgrn" }, new string[] { "vlsyqg", "lrauqzk", "gdhekde" }, new string[] { "zawbrvg" }, new string[] { "wqgczyl", "ilgue", "bwdfntd", "zlgst" }, new string[] { "qhyan", "obxyz", "ahutsc" }, new string[] { "vrppl" }, new string[] { "rqebmc", "snnxhgn", "anucwoj" }, new string[] { "hhpib" }, new string[] { "iqdjcwm" }, new string[] { "xpmpulq" }, new string[] { "afckhxn" }, new string[] { "uynmvcu", "imxraee", "rmfwij" }, new string[] { "cybhcko", "pgfomf", "dacrm" }, new string[] { "ylrxgoz" }, new string[] { "edmzea" }, new string[] { "xuokqm" }, new string[] { "rmfwij" }, new string[] { "gtezger" }, new string[] { "dmjech" }, new string[] { "avbnxz" }, new string[] { "aapssr", "twimhx", "wfdiqkg", "guuri", "qwada", "mwsivlf" }, new string[] { "guuri", "ydmxb", "lndfaxo", "sjfue", "hufrsq", "rxfma" }, new string[] { "uyaarr" }, new string[] { "jtudcya" }, new string[] { "fwgdynj" }, new string[] { "kpnbj" }, new string[] { "anucwoj" }, new string[] { "paxdij" }, new string[] { "cadrzx" }, new string[] { "odbbac", "lnkowzc", "zqcluqc", "pvatk", "thymhif", "gchcumo", "rffqotx", "juscmde" }, new string[] { "maiiqc", "apagba", "mhhbej" }, new string[] { "voeps" }, new string[] { "apagba" }, new string[] { "drpgz", "zabqp", "vercm", "maiiqc", "egyfwlq" }, new string[] { "hgtyjhv", "ffqwo", "yqzdjj", "yrwcj", "ilxgo", "bvoxahz", "iymrfq" }, new string[]{
        //"zjevsui","feiitan","upgfr"}, new string[]{
        //"btzlwo"}, new string[]{
        //"vzpqvfx"}, new string[]{
        //"liwqqqi","ckdeo","movesh","abgfgav","mrlnt"}, new string[]{
        //"udslj"}, new string[]{
        //"twhcdv","uqzoo","ytwvl","gjxgd","ehcrq"}, new string[]{
        //"qtfzj"}, new string[]{
        //"xlufcc","qlsdtum","swkor","ndsvlr"}, new string[]{
        //"hghpgj"}, new string[]{
        //"oxckpuw","nssexu","uwogu"}, new string[]{
        //"rlwyzv"}, new string[]{
        //"wontek","lqfsw","ejljdxo","jtudcya"}, new string[]{
        //"zpeuqlo"}, new string[]{
        //"coibvjw"}, new string[]{
        //"xuqozk"}, new string[]{
        //"wdyxwia"}, new string[]{
        //"zetdtq"}, new string[]{
        //"enymia","ckurzc","lcohspm"}, new string[]{
        //"heotf","gminpu","jodhx"}, new string[]{
        //"bttlx"}, new string[]{
        //"snnxhgn"}, new string[]{
        //"uqcxvh"}, new string[]{
        //"zvxhi"}, new string[]{
        //"yfzypu"}, new string[]{
        //"xhrttm"}, new string[]{
        //"erhiag"}, new string[]{
        //"wbnux"}, new string[]{
        //"upgfr"}, new string[]{
        //"hxkeypq"}, new string[]{
        //"dexabuc"}, new string[]{
        //"cjjwz"}, new string[]{
        //"kbdcl"}, new string[]{
        //"rrmtlri","jkknc","vvkrst","vblyk","ghiftw","tilvzsd","drzoi"}, new string[]{
        //"ujaiypo"}, new string[]{
        //"mgcyq"}, new string[]{
        //"mqrgut","dhfrnu","bzijz"}, new string[]{
        //"zobnnps"}, new string[]{
        //"cxjmggj","kmkqsvl","remwhfn"}, new string[]{
        //"xpinqek"}, new string[]{
        //"fzvyv"}, new string[]{
        //"vvkrst"}, new string[]{
        //"lrdmltp"}, new string[]{
        //"mjgilv","ifegka","olwcj","eheeelo","cvjhub"}, new string[]{
        //"rhqfa"}, new string[]{
        //"wswjfu"}, new string[]{
        //"tqbouv","dtqxiic","chsuzvr"}, new string[]{
        //"xxyjm"}, new string[]{
        //"jofbj","vikplll","vjaqo"}, new string[]{
        //"zbtptb","hiuuk","diriz","liudq"}, new string[]{
        //"ixuyx"}, new string[]{
        //"yfkgike","dhrnu","ehzvm"}, new string[]{
        //"rchhwx"}, new string[]{
        //"gatdc"}, new string[]{
        //"zheomzg","kkimdb","hhomxd"}, new string[]{
        //"lzstd"}, new string[]{
        //"zqzrxe"}, new string[]{
        //"kpnjmwz"}, new string[]{
        //"qvpob","vtzfsci","uexfxv"}, new string[]{
        //"ckurzc"}, new string[]{
        //"rpxhqmz"}, new string[]{
        //"mhhyoxf"}, new string[]{
        //"ryiytg"}, new string[]{
        //"kmxek","rbgonm","qgfxzo","sghuxq","hauul"}, new string[]{
        //"idprbpo","wkurl","plwdhth","staoh"}, new string[]{
        //"liudq"}, new string[]{
        //"cmouh","hmulqgo","qjsjrz","owkily","jkqbf","bipzxj"}, new string[]{
        //"pneftv"}, new string[]{
        //"ulwzhy"}, new string[]{
        //"vbdycf","uwrmetx","lruhvsn","hssfwi"}, new string[]{
        //"gdckdzx"}, new string[]{
        //"dueof"}, new string[]{
        //"hooxvp","rahsrp","uqcxvh"}, new string[]{
        //"nxgnumb","hdmdxi","oxxse","jhmvp"}, new string[]{
        //"vekdbjs","etznlt","kvwqrd","udslj"}, new string[]{
        //"ptamwey","laovxxw","cpdtw"}, new string[]{
        //"ictgyp","zbiypv","rrmtlri","odbbac","tkqke"}, new string[]{
        //"dybitt","ulwzhy","wrumij"}, new string[]{
        //"cfuned"}, new string[]{
        //"nvgnls"}, new string[]{
        //"iwdjjf"}, new string[]{
        //"fvifqfr","uxgbnjk","phckimp","apeba","udzzv"}, new string[]{
        //"cbtgtqb"}, new string[]{
        //"yidnjq"}, new string[]{
        //"bbdayq"}, new string[]{
        //"bzzsss"}, new string[]{
        //"zedqbr"}, new string[]{
        //"yljjx","wumlwia","rnvlepv"}, new string[]{
        //"sarwcau"}, new string[]{
        //"rquaisv","fbbkkxh","xhodzi"}, new string[]{
        //"zlgst"}, new string[]{
        //"dxxzpr"}, new string[]{
        //"vatlgyb"}, new string[]{
        //"qojqcd"}, new string[]{
        //"azpmzli","xodsc","tzlzl"}, new string[]{
        //"husns","btzlwo","sntovuq"}, new string[]{
        //"wltlu"}, new string[]{
        //"nzzwzmh"}, new string[]{
        //"apeba"}, new string[]{
        //"cflrkd"}, new string[]{
        //"fbmalu","qtqbdp","ldrfyi"}, new string[]{
        //"qnvby"}, new string[]{
        //"ovgpa"}, new string[]{
        //"weejuk"}, new string[]{
        //"ourium"}, new string[]{
        //"yckuqt"}, new string[]{
        //"hyyeb"}, new string[]{
        //"hgrwjoy"}, new string[]{
        //"cfqczei"}, new string[]{
        //"bhwnch","qhyan","fvifqfr","rquaisv"}, new string[]{
        //"iibalc","dgmevpb","mojye","zcfztz","qsvyfv","ulxxt","hzxiv","spovj"}, new string[]{
        //"tlpydjm"}, new string[]{
        //"pfvoay"}, new string[]{
        //"vmpev"}, new string[]{
        //"eheeelo"}, new string[]{
        //"tzlzl"}, new string[]{
        //"oncjf"}, new string[]{
        //"kirowa"}, new string[]{
        //"uqzqmo","pgkeahi","owgile"}, new string[]{
        //"pwxorqj"}, new string[]{
        //"dhfrnu"}, new string[]{
        //"ogjqrb"}, new string[]{
        //"mwsivlf","xcstcy","jluccf","pftdcqs"}, new string[]{
        //"cqbtoo"}, new string[]{
        //"hlysw"}, new string[]{
        //"ekgsba"}, new string[]{
        //"zcfztz","scyuq","vggwo"}, new string[]{
        //"owgile"}, new string[]{
        //"keczktv"}, new string[]{
        //"gtixbu"}, new string[]{
        //"hgywlzc","osysik","fmmgboi"}, new string[]{
        //"bwdfntd"}, new string[]{
        //"atoveeu","crtnt","qnvby"}, new string[]{
        //"muecmt"}, new string[]{
        //"tqjzv"}, new string[]{
        //"zsraq"}, new string[]{
        //"idoml"}, new string[]{
        //"mwgimvy"}, new string[]{
        //"gchcumo","msqtvwu","feqefvb"}, new string[]{
        //"zrmqrif"}, new string[]{
        //"qsrfkq","sgxil","tiugk"}, new string[]{
        //"lrauqzk"}, new string[]{
        //"dckozkt","kbefh","pnqri","zdnvz","tuzquw"}, new string[]{
        //"evsnlxn"}, new string[]{
        //"vwwvjg","nqqxz","dfewulo","qsrfkq"}, new string[]{
        //"dacrm"}, new string[]{
        //"wnrqkg"}, new string[]{
        //"nimeytn","difavgr","idcvpt","mjgrhot","glllgqs","qsguy"}, new string[]{
        //"bdrerk","oswqr","gjjyumz"}, new string[]{
        //"zfdhua","deewhp","nerzb"}, new string[]{
        //"kfjbjl","hatmf","tywedfu"}, new string[]{
        //"vsijk","hvtsr","qwhelvj"}, new string[]{
        //"lcohspm"}, new string[]{
        //"brqvmh"}, new string[]{
        //"sinhju"}, new string[]{
        //"uilshuf"}, new string[]{
        //"jodhx"}, new string[]{
        //"puiks"}, new string[]{
        //"wvuqq"}, new string[]{
        //"zamje"}, new string[]{
        //"rqfjzox"}, new string[]{
        //"yjfazsr"}, new string[]{
        //"kufsr","sdeana","byrxbgo","tvarspr"}, new string[]{
        //"nbmat"}, new string[]{
        //"gwrred","aujwg","touzm"}, new string[]{
        //"svkcvg","rbzqh","abnhpi","zrmqrif","kvtpc"}, new string[]{
        //"dasbhc","pmlim","gwoiid"}, new string[]{
        //"opnbls"}, new string[]{
        //"knqqz","vebli","axwdrai"}, new string[]{
        //"jyzrmnp"}, new string[]{
        //"difavgr","ukzfd","rxkpkvi"}, new string[]{
        //"wpjaa"}, new string[]{
        //"sbfhxsx","pusdii","qqodh","tlpydjm","jgoaja"}, new string[]{
        //"qaedcl"}, new string[]{
        //"oxwnu"}, new string[]{
        //"gtvpf","knqqz","qzfwf","vlsyqg","anvxtbs","idprbpo"}, new string[]{
        //"huansqc"}, new string[]{
        //"oaabog","nmbql","yodnj","yrluhjr"}, new string[]{
        //"ghiftw","gpikz","mvkxva"}, new string[]{
        //"qfhfg"}, new string[]{
        //"zqcluqc","kdwzx","yflpz","aokvbbi"}, new string[]{
        //"twimhx","xsmdo","gpormp","akioek"}, new string[]{
        //"brdbeoe"}, new string[]{
        //"cfshobe"}, new string[]{
        //"jojnh"}, new string[]{
        //"ettsd","rzpmulz","fmjfhoo"}, new string[]{
        //"liymh"}, new string[]{
        //"hmulqgo","xjrheul","cykhmjj"}, new string[]{
        //"zbptsb"}, new string[]{
        //"vjaqo"}, new string[]{
        //"wmfro","mcpyfmy","rzlxx"}, new string[]{
        //"wpprys","tkcmrl","dxxzpr"}, new string[]{
        //"farpozz","wepvw","zzjmukx","ooenol"}, new string[]{
        //"wpwxn"}, new string[]{
        //"izphu"}, new string[]{
        //"epuiwg"}, new string[]{
        //"efcqep"}, new string[]{
        //"dnvqlog"}, new string[]{
        //"knwlsi"}, new string[]{
        //"zfrsmm","aapsp","gfsnb","jojnh"}, new string[]{
        //"zjxcrv"}, new string[]{
        //"lnkowzc","aaqsdv","ujaiypo"}, new string[]{
        //"vgtxty","fcbxsf","acchih"}, new string[]{
        //"grgjs","uvntywl","nzzwzmh"}, new string[]{
        //"lewfa","aouljs","swvae","ybwgz","spdsz"}, new string[]{
        //"nfgmyd","yljjx","lcdleci","zcoyhde"}, new string[]{
        //"zzjmukx"}, new string[]{
        //"vjwptwp"}, new string[]{
        //"spfds"}, new string[]{
        //"vqbsvk"}, new string[]{
        //"eyslsq","oncjf","nuibgd"}, new string[]{
        //"gvegx","qhujoiu","dpvmn","cyhnayc"}, new string[]{
        //"opfey"}, new string[]{
        //"ypiwj","pupaehu","hekhbd","kgfldlb","atoveeu","zobnnps","iukfd"}, new string[]{
        //"vzkneq","gvegx","mqrgut","bsvmale","fjueoko","cdoed"}, new string[]{
        //"kynrf","bnmgqen","iuftirx"}, new string[]{
        //"wibgm","zetdtq","dcytmqp","xfxqvk"}, new string[]{
        //"alycm"}, new string[]{
        //"rcnhfcz"}, new string[]{
        //"smbkvwd","rvwvqij","avbnxz"}, new string[]{
        //"kitggwr"}, new string[]{
        //"kbsmiq"}, new string[]{
        //"touzm"}, new string[]{
        //"xyfeczu"}, new string[]{
        //"slnezfv"}, new string[]{
        //"xpizz"}, new string[]{
        //"seicwz","izpxbq","gdomj","jrsbjr"}, new string[]{
        //"mbjsjy"}, new string[]{
        //"aoltxw"}, new string[]{
        //"zztvgwh"}, new string[]{
        //"rznqdxq"}, new string[]{
        //"vggwo"}, new string[]{
        //"tlxdyxj","cnztmm","dkjwj","drigjl"}, new string[]{
        //"qjsjrz","aqrxpru","polnw"}, new string[]{
        //"khpntc","hxkeypq","wfefbdt","mhbov"}, new string[]{
        //"qrdtzc"}, new string[]{
        //"glllgqs","paxdij","yidnjq"}, new string[]{
        //"jnghyrm","soebcx","opfey"}, new string[]{
        //"abnhpi"}, new string[]{
        //"tziqot","peyyn","chwoyn"}, new string[]{
        //"hgdbip"}, new string[]{
        //"goqhcu"}, new string[]{
        //"kddex","goqhcu","rxohrzb","ucsvcy"}, new string[]{
        //"zfzwko"}, new string[]{
        //"uhjxtrp"}, new string[]{
        //"zmzwttu"}, new string[]{
        //"vdyftz","ypttuns","gfcfsf","ymonx","fjdyms"}, new string[]{
        //"ctien","cqbtoo","hghpgj"}, new string[]{
        //"jfqlxa"}, new string[]{
        //"nhwgy"}, new string[]{
        //"lruhvsn","ljeiizi","opctg"}, new string[]{
        //"uxvgnv"}, new string[]{
        //"cwdoo","eozev","gohdd"}, new string[]{
        //"ghkmb","pnuvuf","nskayc"}, new string[]{
        //"wumlwia"}, new string[]{
        //"xryqzl"}, new string[]{
        //"fbhnbdw"}, new string[]{
        //"wuijd"}, new string[]{
        //"dannmef"}, new string[]{
        //"aokgycq"}, new string[]{
        //"wfefbdt"}, new string[]{
        //"zmqxmtf"}, new string[]{
        //"biioe"}, new string[]{
        //"wwcqz"}, new string[]{
        //"echdbt"}, new string[]{
        //"tdtxcm"}, new string[]{
        //"tvarspr"}, new string[]{
        //"zkhtua","zmbimk","kmxek","tziqot","aewbhax"}, new string[]{
        //"phckimp"}, new string[]{
        //"rcomsru"}, new string[]{
        //"aaztou"}, new string[]{
        //"pwdoio","nxcus","bpbmbq","zbtptb"}, new string[]{
        //"impqm","yumbba","zltzea"}, new string[]{
        //"bkjcc"}, new string[]{
        //"cnztmm"}, new string[]{
        //"jdbel"}, new string[]{
        //"vcjavrw"}, new string[]{
        //"udkba"}, new string[]{
        //"jretzi"}, new string[]{
        //"donza"}, new string[]{
        //"staoh"}, new string[]{
        //"subnd"}, new string[]{
        //"jzrlfrl"}, new string[]{
        //"sgxil"}, new string[]{
        //"wahmvp"}, new string[]{
        //"lvtxk"}, new string[]{
        //"cxrukf"}, new string[]{
        //"atcole","ykwvu","yckuqt"}, new string[]{
        //"bjeto","msoip","wjkky"}, new string[]{
        //"qsvyfv","cfuned","vzayzaq"}, new string[]{
        //"ztodsnq","lqrde","ukvzqny","svzqi"}, new string[]{
        //"pkditpt"}, new string[]{
        //"rgshogg"}, new string[]{
        //"drefe"}, new string[]{
        //"rnqvaa","wvuqq","uifug"}, new string[]{
        //"cpxkqg"}, new string[]{
        //"bstznzu"}, new string[]{
        //"iflhr"}, new string[]{
        //"pczpj"}, new string[]{
        //"jhmvp"}, new string[]{
        //"aouljs"}, new string[]{
        //"ndqomrl","fhyfhjg","qnbnflf"}, new string[]{
        //"wrumij"}, new string[]{
        //"ehcrq","cpllg","asnsvv"}, new string[]{
        //"auvkb"}, new string[]{
        //"gdomj"}, new string[]{
        //"dnnlgt"}, new string[]{
        //"wasnz"}, new string[]{
        //"rzpmulz"}, new string[]{
        //"tiugk"}, new string[]{
        //"sdjzc"}, new string[]{
        //"jdxth"}, new string[]{
        //"aeeas"}, new string[]{
        //"crtnt"}, new string[]{
        //"ytwvl","nqjmi","mwgimvy"}, new string[]{
        //"avmhq"}, new string[]{
        //"juscmde"}, new string[]{
        //"kbpvvf"}, new string[]{
        //"wegmegy","oaantta","fzvyv"}, new string[]{
        //"kfdtg"}, new string[]{
        //"matvb"}, new string[]{
        //"ehzvm"}, new string[]{
        //"ebxyi"}, new string[]{
        //"qgfxzo"}, new string[]{
        //"zoodui"}, new string[]{
        //"dapjhx"}, new string[]{
        //"ywawq","ptcby","kufsr","pxsuagy"}, new string[]{
        //"laovxxw"}, new string[]{
        //"furny","lgxjcy","hcsiqp","vsijk"}, new string[]{
        //"gzocll"}, new string[]{
        //"kifypgu"}, new string[]{
        //"kywpr"}, new string[]{
        //"eikjv"}, new string[]{
        //"wjkky"}, new string[]{
        //"fkwsxxk","eyixz","bjeto","ghkmb"}, new string[]{
        //"weeriq"}, new string[]{
        //"rxkpkvi"}, new string[]{
        //"bipzxj","bpgafw","ilidonx","uxswi"}, new string[]{
        //"trjird"}, new string[]{
        //"istoj"}, new string[]{
        //"idcvpt","zzdgmmd","imakkq","jbodnl"}, new string[]{
        //"pehio","bstznzu","xzdhzoa"}, new string[]{
        //"exxbgm"}, new string[]{
        //"tuzquw"}, new string[]{
        //"ydmxb","udoiqj","isfyuxu","hgtyjhv","tlxdyxj","inreau","qiinez"}, new string[]{
        //"jmsuq"}, new string[]{
        //"dkjwj","nbbiqh","nbfbkao"}, new string[]{
        //"xxbwj","xpinqek","xqmsvth"}, new string[]{
        //"dfewulo","phmmydn","eyjdqm","qpblhez"}, new string[]{
        //"ukvzqny"}, new string[]{
        //"gpormp","ymogkwe","ywtwrq","hixtw","zmssxbl","twhcdv"}, new string[]{
        //"diriz"}, new string[]{
        //"zltzea"}, new string[]{
        //"jkqbf","wpwxn","vzpqvfx","muecmt","trjird"}, new string[]{
        //"uodyv"}, new string[]{
        //"fhqah"}, new string[]{
        //"aapsp","nvhbnlc","dzqax","ndjjag","dmjech"}, new string[]{
        //"bxfwhrd"}, new string[]{
        //"knoziw","sinhju","otbxf","udkba"}, new string[]{
        //"wbupk"}, new string[]{
        //"ixvxtb"}, new string[]{
        //"rnvlepv"}, new string[]{
        //"nerzb"}, new string[]{
        //"brtmsqe"}, new string[]{
        //"gjjyumz"}, new string[]{
        //"ogpvd"}, new string[]{
        //"ypttuns"}, new string[]{
        //"yzkpvn"}, new string[]{
        //"hssfwi","qfhfg","uvkecqz"}, new string[]{
        //"ooenol"}, new string[]{
        //"mucpe"}, new string[]{
        //"bpbmbq","irkhv","navnyn","bzzsss","wbnux"}, new string[]{
        //"kkimdb"}, new string[]{
        //"sfgatoz"}, new string[]{
        //"bqfor"}, new string[]{
        //"tobsrs"}, new string[]{
        //"polnw"}, new string[]{
        //"xlqycb"}, new string[]{
        //"uwrmetx"}, new string[]{
        //"jtjzsr"}, new string[]{
        //"tehdy"}, new string[]{
        //"feiitan"}, new string[]{
        //"hcsiqp","rlwyzv","liymh","huzjje","spfds"}, new string[]{
        //"udghm"}, new string[]{
        //"iequdmw","cwxgg","geqnwz","smbkvwd","swhnbvw","uynmvcu"}, new string[]{
        //"mwxiwty","lvtxk","ylrxgoz"}, new string[]{
        //"xqmsvth"}, new string[]{
        //"ulszh"}, new string[]{
        //"cpllg"}, new string[]{
        //"oswpicl"}, new string[]{
        //"gcglasa","nbmat","cfqczei"}, new string[]{
        //"kdwzx"}, new string[]{
        //"igumiu","ggynw","lrodp"}, new string[]{
        //"jptqm","avrfgx","mucpe"}, new string[]{
        //"yrwcj","cfshobe","mgcyq"}, new string[]{
        //"uvkecqz"}, new string[]{
        //"mjgrhot","sdjzc","cjjwz"}, new string[]{
        //"ohuvi"}, new string[]{
        //"uplxy"}, new string[]{
        //"ymfurx"}, new string[]{
        //"vrkrr"}, new string[]{
        //"tkxuj"}, new string[]{
        //"mydixq"}, new string[]{
        //"obgin","lewfa","ukwydlj","xyfeczu"}, new string[]{
        //"swvae"}, new string[]{
        //"adlvipk","uilshuf","qxkilb"}, new string[]{
        //"vxjhric"}, new string[]{
        //"mhbeqm"}, new string[]{
        //"vcyfwm","qrdtzc","gatdc"}, new string[]{
        //"xujof"}, new string[]{
        //"rjkhl","mogla","nlewmv","mxxecyh"}, new string[]{
        //"oxqvzzv"}, new string[]{
        //"rwxmoi","dnvqlog","ogpvd"}, new string[]{
        //"tcybjv","iuneyv","cgszcig"}, new string[]{
        //"xtpgpbx"}, new string[]{
        //"umtpolq"}, new string[]{
        //"zkdwxd"}, new string[]{
        //"gqiiycg"}, new string[]{
        //"pftdcqs","xeefzwg","vyudgjy","ylvvgmj","fefnhby","ypiwj"}, new string[]{
        //"vyudgjy","ettsd","knastam","jretzi","rqebmc","kngspv","onudby","opnbls"}, new string[]{
        //"micfuva"}, new string[]{
        //"dgmevpb","xcmre","upslw"}, new string[]{
        //"ncghncy"}, new string[]{
        //"oxtckvl","erhiag","kvcak"}, new string[]{
        //"tilvzsd","slnezfv","sxick"}, new string[]{
        //"snaebf"}, new string[]{
        //"sdnzxl","xhkrx","tcmkx"}, new string[]{
        //"qdpcslx"}, new string[]{
        //"ymogkwe","srqbs","hgrwjoy","khpntc","atcole","spdyx"}, new string[]{
        //"tywedfu"}, new string[]{
        //"chhmaxr"}, new string[]{
        //"onudby","zvxhi","zmqxmtf"}, new string[]{
        //"xdwzfh"}, new string[]{
        //"avrfgx"}, new string[]{
        //"ctafsp"}, new string[]{
        //"cnbvz","zpeuqlo","iqdjcwm"}, new string[]{
        //"uuijd"}, new string[]{
        //"gwlyvbx"}, new string[]{
        //"aewbhax","glhbvi","ulszh","rbawcc"}, new string[]{
        //"fcbxsf"}, new string[]{
        //"yqzxa"}, new string[]{
        //"bbmbn"}, new string[]{
        //"nskayc"}, new string[]{
        //"ywuxmil","wasnz","ryiytg","raaxwq","jtkrr"}, new string[]{
        //"dtrxzld","wontek","rjkhl","rwxmoi"}, new string[]{
        //"shetkt","jqmcro","rqfjzox"}, new string[]{
        //"movesh"}, new string[]{
        //"uylnr"}, new string[]{
        //"uexfxv"}, new string[]{
        //"tjxms","cfwox","vpcfu","boiuyt","nvgnls"}, new string[]{
        //"cyhnayc"}, new string[]{
        //"rwtdhr"}, new string[]{
        //"glxtiz"}, new string[]{
        //"hhmrwj","oswpicl","bxfwhrd"}, new string[]{
        //"nwkxd"}, new string[]{
        //"dxgntli"}, new string[]{
        //"xodsc"}, new string[]{
        //"ffgplgk","bkjcc","bclkir","cwhjt"}, new string[]{
        //"fdcnhr"}, new string[]{
        //"waojp"}, new string[]{
        //"jtkrr"}, new string[]{
        //"mhbov"}, new string[]{
        //"sxick"}, new string[]{
        //"qwhelvj"}, new string[]{
        //"thrmrw","tliov","xhpvb","vjbjy"}, new string[]{
        //"navnyn"}, new string[]{
        //"rpjiwuz","jmsuq","ctqgj"}, new string[]{
        //"cfwox"}, new string[]{
        //"ghwwfca","fsmidq","aaztou","bpcrtwl","vfojca"}, new string[]{
        //"pnqri"}, new string[]{
        //"lqdqct"}, new string[]{
        //"etznlt"}, new string[]{
        //"geqnwz"}, new string[]{
        //"orydf"}, new string[]{
        //"ywtwrq","qfbqiv","ghwwfca","zfdhua"}, new string[]{
        //"ayrucb"}, new string[]{
        //"jkmernz"}, new string[]{
        //"rxohrzb"}, new string[]{
        //"rffqotx","rgshogg","axrep"}, new string[]{
        //"xxtdti"}, new string[]{
        //"jluccf","xlpzp","obgin","dtrxzld","nzbknfm","ldfhqjw"}, new string[]{
        //"pnuvuf"}, new string[]{
        //"iqqevm"}, new string[]{
        //"iuftirx"}, new string[]{
        //"sprno"}, new string[]{
        //"zcyfth"}, new string[]{
        //"poenou","evsnlxn","mhbeqm"}, new string[]{
        //"pxifep"}, new string[]{
        //"tlgew"}, new string[]{
        //"xriiu"}, new string[]{
        //"hxzthym","zsbcn","nwejb","dckozkt","grgjs"}, new string[]{
        //"jagoxt"}, new string[]{
        //"nuibgd"}, new string[]{
        //"emqqx"}, new string[]{
        //"erzayz","ywuxmil","clhyd","yqzxa","cxjmggj","kcqvnd","cvipqzv"}, new string[]{
        //"umjwkfc","wpcry","pkbxhn","xmnreh"}, new string[]{
        //"tjnxnd","gnitpo","yfzypu"}, new string[]{
        //"kxftjs","tjxkxom","hrbsamg","qvpob"}, new string[]{
        //"dbrlat","sprno","waojp"}, new string[]{
        //"dqggz"}, new string[]{
        //"aqrxpru"}, new string[]{
        //"qedsq","sscfkq","waxrcby","fkwsxxk"}, new string[]{
        //"kngspv","hhuhid","mhoaev"}, new string[]{
        //"yonxye","qallt","vmpev"}, new string[]{
        //"goqdmgy","fiwbd","ekgsba"}, new string[]{
        //"nboczvq"}, new string[]{
        //"zlrvs"}, new string[]{
        //"zabqp","uxvgnv","huansqc"}, new string[]{
        //"ndsvlr","mbjsjy","mjxtbvx"}, new string[]{
        //"hnnjspe","wuijd","aokgycq","yzkpvn"}, new string[]{
        //"hjjri","vrkrr","jaxae"}, new string[]{
        //"bvoxahz","kmvkkze","nboczvq"}, new string[]{
        //"bpareqw","pehio","pxjve","zqbtgtw"}, new string[]{
        //"afpxssv"}, new string[]{
        //"ibzpdf","gywnt","jogksw"}, new string[]{
        //"sdeana"}, new string[]{
        //"sgzijsv"}, new string[]{
        //"peyyn"}, new string[]{
        //"xdszea","kbpvvf","vqbsvk"}, new string[]{
        //"kvwqrd"}, new string[]{
        //"tyuyffp","tlcseu","xryqzl","hraby"}, new string[]{
        //"fistzz","vgtxty","bffvo","hnnjspe"}, new string[]{
        //"zqqyhq"}, new string[]{
        //"qwada","wfkcsb","qlboef","pkowhq"}, new string[]{
        //"remwhfn"}, new string[]{
        //"vatqulm"}, new string[]{
        //"psirxj","rcomsru","aintn"}, new string[]{
        //"mhblqw"}, new string[]{
        //"uwogu"}, new string[]{
        //"fsmidq"}, new string[]{
        //"bsvmale","exxbgm","trvjrbi","subnd","dnnlgt"}, new string[]{
        //"zsbcn"}, new string[]{
        //"ilgue"}, new string[]{
        //"ldsbhlt","ayrucb","hlysw"}, new string[]{
        //"scyuq"}, new string[]{
        //"piqgu","dkwde","dkhjdb","dqoatul","psirxj","mbmaqh","gxdqpcd"}, new string[]{
        //"qsemjfo","yjfazsr","aeiktt"}, new string[]{
        //"bfxmh"}, new string[]{
        //"rrnjpdu","lmuwznh","iflhr"}, new string[]{
        //"jaxae"}, new string[]{
        //"nbbiqh"}, new string[]{
        //"vwisj"}, new string[]{
        //"gwoiid"}, new string[]{
        //"ctidma","ncghncy","swpvgrn","xwtgr","vjwptwp"}, new string[]{
        //"oovlaqz"}, new string[]{
        //"fezhnw","ixuyx","pkesm","fdcnhr","qtfzj"}, new string[]{
        //"hauul"}, new string[]{
        //"dkhjdb","dannmef","qaedcl"}, new string[]{
        //"rtlde","glxtiz","rhqfa"}, new string[]{
        //"qtfuwru"}, new string[]{
        //"mqyipy"}, new string[]{
        //"hvrmmxf"}, new string[]{
        //"swhnbvw","zodbq","qmiurj","idoml","efcqep"}, new string[]{
        //"zcoyhde","esjuqh","vxucz","kifypgu","bveaw"}, new string[]{
        //"qhujoiu"}, new string[]{
        //"sophzzn","uhjxtrp","vatlgyb"}, new string[]{
        //"wfhixl"}, new string[]{
        //"eyixz","hmeolu","lumomlj"}, new string[]{
        //"ldrzzzz"}, new string[]{
        //"hdmdxi"}, new string[]{
        //"azrcn"}, new string[]{
        //"jbodnl"}, new string[]{
        //"dkrdqpo"}, new string[]{
        //"wpcry"}, new string[]{
        //"ivnufgs"}, new string[]{
        //"mgreg"}, new string[]{
        //"vxobef"}, new string[]{
        //"nxcus","wdyxwia","nhhyvm"}, new string[]{
        //"bdgwdt"}, new string[]{
        //"mculw"}, new string[]{
        //"jmavfy"}, new string[]{
        //"asnsvv"}, new string[]{
        //"wpezq","qppamj","pokjgkl"}, new string[]{
        //"gsaci","tkxuj","jzrlfrl"}, new string[]{
        //"eeuohnm"}, new string[]{
        //"zzdgmmd"}, new string[]{
        //"msoip"}, new string[]{
        //"spovj","lqdqct","omxny"}, new string[]{
        //"covpz","wbzwxs","hvlfx"}, new string[]{
        //"ukzfd"}, new string[]{
        //"ygldlhw","bbmbn","coibvjw"}, new string[]{
        //"xmnreh"}, new string[]{
        //"nssexu"}, new string[]{
        //"zibnjxk"}, new string[]{
        //"fhyfhjg"}, new string[]{
        //"jaebowl"}, new string[]{
        //"vfojca"}, new string[]{
        //"gminpu"}, new string[]{
        //"ylpahav"}, new string[]{
        //"zdnvz"}, new string[]{
        //"tlulph"}, new string[]{
        //"hvlfx"}, new string[]{
        //"sadhkpb","edmzea","pczpj","jxevrgz"}, new string[]{
        //"thymhif"}, new string[]{
        //"ewfql"}, new string[]{
        //"cykhmjj"}, new string[]{
        //"xlpzp","jnghyrm","nxgnumb","ldsbhlt","svkcvg","avnosfl","shetkt"}, new string[]{
        //"ylvvgmj","csvxlo","enymia","dasbhc"}, new string[]{
        //"tdfgfqn"}, new string[]{
        //"rnyarzh"}, new string[]{
        //"exgsu"}, new string[]{
        //"heqvbi"}, new string[]{
        //"ybwgz"}, new string[]{
        //"rbzqh"}, new string[]{
        //"iwwngux","hvrmmxf","nebwj","bfxmh","fkrdkav"}, new string[]{
        //"wolyko"}, new string[]{
        //"jrsbjr","vxobef","zsjoz"}, new string[]{
        //"wowgkro","vcvjtf","biioe"}, new string[]{
        //"xjrheul"}, new string[]{
        //"gohdd"}, new string[]{
        //"tlfbyq","zqzrxe","jagoxt","zawbrvg","chhmaxr"}, new string[]{
        //"jgoaja"}, new string[]{
        //"ghmxos"}, new string[]{
        //"bvqcnc"}, new string[]{
        //"ffqwo","ohuvi","ygtbl"}, new string[]{
        //"qallt"}, new string[]{
        //"aujwg"}, new string[]{
        //"upslw"}, new string[]{
        //"axwdrai"}, new string[]{
        //"hyeetiq"}, new string[]{
        //"inreau","rosop","baimp","oxckpuw","nehwool","rrnjpdu","rqecouz"}, new string[]{
        //"wfdiqkg","ictgyp","yffxaiy","prvckio","qedsq","fjmjc"}, new string[]{
        //"obxyz"}, new string[]{
        //"hatmf"}, new string[]{
        //"xffmho","xdszea","qsemjfo","fvfehj"}, new string[]{
        //"omxny"}, new string[]{
        //"kfjqheo","gwrred","bvqcnc","unscz"}, new string[]{
        //"bffvo","puiks","zfzwko","xlqycb"}, new string[]{
        //"tpbeg","sgzijsv","ysgnao"}, new string[]{
        //"onwqp","mowkbi","gsaci","wuogj","ztodsnq","tqbouv"}, new string[]{
        //"fcfbxmb"}, new string[]{
        //"iuneyv"}, new string[]{
        //"qybyrm"}, new string[]{
        //"cszchsg","ieqgh","fezhnw","sophzzn","dbrlat","igumiu"}, new string[]{
        //"lrodp"}, new string[]{
        //"qmiurj"}, new string[]{
        //"rbawcc"}, new string[]{
        //"hhomxd"}, new string[]{
        //"euriiux"}, new string[]{
        //"esjuqh"}, new string[]{
        //"pxsuagy","ewfql","gdckdzx"}, new string[]{
        //"xhpvb"}, new string[]{
        //"jroea","jmavfy","udghm","tdtxcm"}, new string[]{
        //"tmfyif"}, new string[]{
        //"stfqd","zqqyhq","uplxy","rznqdxq","xpizz"}, new string[]{
        //"vcwlaw","zeaxycf","izphu"}, new string[]{
        //"eyrgmc","bbdayq","avmhq"}, new string[]{
        //"pusdii"}, new string[]{
        //"cgszcig"}, new string[]{
        //"byrxbgo"}, new string[]{
        //"ukwydlj","vvqtv","ffjie"}, new string[]{
        //"boiuyt"}, new string[]{
        //"mnbkaa","pneftv","gqiiycg","hrqaph"}, new string[]{
        //"vxucz"}, new string[]{
        //"ejljdxo"}, new string[]{
        //"dkwde","shwsv","oovlaqz"}, new string[]{
        //"aktswyh"}, new string[]{
        //"dvvkzv"}, new string[]{
        //"qppamj"}, new string[]{
        //"bftoy"}, new string[]{
        //"dzqax"}, new string[]{
        //"rlrnjnz","dqggz","wpjaa"}, new string[]{
        //"qzfwf","ldrzzzz","cxfqupv"}, new string[]{
        //"ffjie"}, new string[]{
        //"mowkbi","uuijd","umtpolq","twxnswy","ivowf"}, new string[]{
        //"ljeiizi"}, new string[]{
        //"emsjxz","jaebowl","vyxgc","voeps"}, new string[]{
        //"hrqgfhg","vcwlaw","dsrostg","tfzsp","jptqm","vmuqpj","jfmuzo"}, new string[]{
        //"xwtgr"}, new string[]{
        //"ctqgj"}, new string[]{
        //"bwqxk","xtpgpbx","dkrdqpo","wfhixl","yiyhuxk"}, new string[]{
        //"kpwfqfc"}, new string[]{
        //"ulxxt","xuqozk","tyxfxu"}, new string[]{
        //"yumbba"}, new string[]{
        //"rvwvqij"}, new string[]{
        //"prvckio","zqjqic","kfjqheo","cszchsg"}, new string[]{
        //"uifug"}, new string[]{
        //"zeaxycf"}, new string[]{
        //"cxfqupv"}, new string[]{
        //"kcqvnd"}, new string[]{
        //"pxjve","rizbeea","brdbeoe"}, new string[]{
        //"mhoaev"}, new string[]{
        //"rzlxx"}, new string[]{
        //"rnoaimc"}, new string[]{
        //"olwcj"}, new string[]{
        //"fmmgboi"}, new string[]{
        //"bclkir"}, new string[]{
        //"hraby"}, new string[]{
        //"jqmcro"}, new string[]{
        //"kvcak"}, new string[]{
        //"msqtvwu"}, new string[]{
        //"trvjrbi"}, new string[]{
        //"jogksw"}, new string[]{
        //"cdoed","tlgew","rwtdhr","wahmvp"}, new string[]{
        //"qpblhez"}, new string[]{
        //"rqecouz","emqqx","xhrttm"}, new string[]{
        //"zmbimk","zbptsb","wrbknnc","iqqevm"}, new string[]{
        //"zmssxbl","tjnxnd","ibzpdf","uwcqi"}, new string[]{
        //"qlsdtum","ibnho","smxwnsk"}, new string[]{
        //"hyzzwx"}, new string[]{
        //"bhvvs","zcyfth","oxwnu"}, new string[]{
        //"soebcx"}, new string[]{
        //"lgltgc"}, new string[]{
        //"lcbljqb","bcpbir","zlubkqa"}, new string[]{
        //"jrkbh"}, new string[]{
        //"icziaym","uqzqmo","mwxiwty","ihskp"}, new string[]{
        //"lqrde"}, new string[]{
        //"hrqaph"}, new string[]{
        //"qyrhb","wegmegy","tjxms","bdrerk"}, new string[]{
        //"zwvjv"}, new string[]{
        //"rizbeea"}, new string[]{
        //"mjxtbvx"}, new string[]{
        //"drfeinj","cpxkqg","donza"}, new string[]{
        //"spdyx","tehdy","afckhxn"}, new string[]{
        //"dqxwazb"}, new string[]{
        //"vblyk","zjklq","wswjfu"}, new string[]{
        //"mcpyfmy"}, new string[]{
        //"xzormv"}, new string[]{
        //"cwhjt"}, new string[]{
        //"drigjl","xxtdti","ewods","dkysxdp"}, new string[]{
        //"fmjfhoo"}, new string[]{
        //"tliov"}, new string[]{
        //"gjxgd","hgdbip","eikjv","keczktv","mhblqw"}, new string[]{
        //"cpdtw"}, new string[]{
        //"xaxuyg","bvfdo","aoltxw"}, new string[]{
        //"dpavyu"}, new string[]{
        //"egyfwlq","cbtgtqb","qtfuwru","mnjirpy"}, new string[]{
        //"llrntn","rcnhfcz","nqzvz","wolyko","jtjzsr"}, new string[]{
        //"fjdyms"}, new string[]{
        //"sjfue","vcyfwm","impqm","llrntn","tpbeg"}, new string[]{
        //"nmbql","bqfor","vatqulm"}, new string[]{
        //"udzzv"}, new string[]{
        //"dsrostg","xriiu","tmfyif"}, new string[]{
        //"ihskp","wltlu","brtmsqe"}, new string[]{
        //"zsxjxs"}, new string[]{
        //"lqfsw"}, new string[]{
        //"qsguy","drefe","ylpahav","dgscbm","emznzp"}, new string[]{
        //"ilidonx"}, new string[]{
        //"hekhbd"}, new string[]{
        //"zodbq"}, new string[]{
        //"fjueoko","jkmernz","exgsu","tlulph"}, new string[]{
        //"idqaieo","sfgatoz","dvvkzv","auvkb"}, new string[]{
        //"udoiqj","sbfhxsx","fbmalu","husns"}, new string[]{
        //"fbbkkxh"}, new string[]{
        //"nzbknfm","thrmrw","cwdoo","zwcucws","knoziw"}, new string[]{
        //"hixtw","rtlde","hhmrwj","lcbljqb","umjwkfc"}, new string[]{
        //"ifegka"}, new string[]{
        //"bnmgqen"}, new string[]{
        //"yodnj","pfvoay","cflrkd"}, new string[]{
        //"hiuuk"}, new string[]{
        //"mlafk","wqgczyl","wnrqkg","wibgm","tpnvx"}, new string[]{
        //"drzoi","lgltgc","cpess"}, new string[]{
        //"dqoatul","fcfbxmb","qququw"}, new string[]{
        //"bibly"}, new string[]{
        //"opctg"}, new string[]{
        //"abwmmuw"}, new string[]{
        //"ucsvcy"}, new string[]{
        //"anvxtbs","jfqlxa","mhhyoxf"}, new string[]{
        //"hwevm"}, new string[]{
        //"qiinez","wpezq","sigxauh","rpxhqmz","xxlwrd","ffgplgk","hvsywx","vekdbjs"}, new string[]{
        //"rhnota"}, new string[]{
        //"mrlnt"}, new string[]{
        //"ytkmda","ctien","ogjqrb","goqdmgy"}, new string[]{
        //"uanby"}, new string[]{
        //"oxxse"}, new string[]{
        //"jkknc","uyaarr","wwcqz","ruvmsg","tdfgfqn"}, new string[]{
        //"xxxxbnh"}, new string[]{
        //"fefnhby","liwqqqi","bftoy","covpz","bhvvs","gcglasa","rnqvaa"}, new string[]{
        //"xsqvwa"}, new string[]{
        //"xmgank","dexabuc","xzormv"}, new string[]{
        //"xxlwrd","zsxjxs","mqyipy"}, new string[]{
        //"yyyel"}, new string[]{
        //"fvfehj","tvisu","hyeetiq","kbsmiq","brqvmh"}, new string[]{
        //"ivowf"}, new string[]{
        //"isfyuxu","ygldlhw","jroea","rpjiwuz"}, new string[]{
        //"cqnmo"}, new string[]{
        //"mxxecyh"}, new string[]{
        //"aaqsdv"}, new string[]{
        //"dkysxdp"}, new string[]{
        //"chsuzvr"}, new string[]{
        //"vjbjy"}, new string[]{
        //"pyzwl"}, new string[]{
        //"izpxbq","wennxvo","fwgdynj"}, new string[]{
        //"fkrdkav"}, new string[]{
        //"kmkqsvl"}, new string[]{
        //"oswqr"}, new string[]{
        //"pvatk","nhwgy","rnyarzh","vwisj"}, new string[]{
        //"gxdqpcd"}, new string[]{
        //"ggynw"}, new string[]{
        //"acchih"}, new string[]{
        //"ldrfyi"}, new string[]{
        //"tjxkxom","zwvjv","tobsrs"}, new string[]{
        //"vyxgc"}, new string[]{
        //"wfkcsb","vxjhric","farpozz","eyslsq","zoodui"}, new string[]{
        //"otbxf"}, new string[]{
        //"shwsv"}, new string[]{
        //"uxswi"}, new string[]{
        //"cvjhub"}, new string[]{
        //"zkyiauj","pqnkr","mnbkaa","xmgank","sadhkpb","tyuyffp"}, new string[]{
        //"akioek","wowgkro","icziaym","nimeytn","hrqgfhg","hxzthym","vzkneq"}, new string[]{
        //"emznzp"}, new string[]{
        //"hvtsr"}, new string[]{
        //"yqzdjj","dueof","jdbel","ixvxtb"}, new string[]{
        //"fqkbscn","kddex","nylhp","xxyjm","agkgi"}, new string[]{
        //"plwdhth"}, new string[]{
        //"abgfgav"}, new string[]{
        //"wbzwxs"}, new string[]{
        //"tlcseu"}, new string[]{
        //"vercm","aejbixg","wbupk"}, new string[]{
        //"uvntywl"}, new string[]{
        //"hmeolu"}, new string[]{
        //"swkor","matvb","rsocykv"}, new string[]{
        //"deewhp"}, new string[]{
        //"bveaw"}, new string[]{
        //"qlboef","gtvpf","qyrhb","xffmho","drpgz","hjjri"}, new string[]{
        //"cvipqzv","xujof","vsffvp"}, new string[]{
        //"mvkxva"}, new string[]{
        //"osysik"}, new string[]{
        //"tkcmrl"}, new string[]{
        //"xfxqvk"}, new string[]{
        //"sscfkq","ckbjuyy","zdlxv","kfjbjl"}, new string[]{
        //"aejbixg"}, new string[]{
        //"lndfaxo","rqsjqrg","onwqp","sdnzxl","erzayz","fistzz"}, new string[]{
        //"bcpbir"}, new string[]{
        //"feqefvb"}, new string[]{
        //"xsmdo","vwwvjg","iibalc","ysgotr","oaabog"}, new string[]{
        //"knastam","zibnjxk","snaebf"}, new string[]{
        //"waxrcby","tcybjv","xsqvwa","poenou","eyrgmc","azpmzli","vdyftz","jofbj"}, new string[]{
        //"bvfdo"}, new string[]{
        //"nvhbnlc"}, new string[]{
        //"vcvjtf"}, new string[]{
        //"mojye","qojqcd","cxrukf"}, new string[]{
        //"qqodh"}, new string[]{
        //"ahutsc"}, new string[]{
        //"vtzfsci"}, new string[]{
        //"wennxvo"}, new string[]{
        //"ykwvu"}, new string[]{
        //"tfzsp","zjmhab","kfdtg"}, new string[]{
        //"mogla"}, new string[]{
        //"rxfma","kxftjs","bpareqw","rlrnjnz"}, new string[]{
        //"ckdeo"}, new string[]{
        //"wkurl"}, new string[]{
        //"huzjje"}, new string[]{
        //"lcdleci"}, new string[]{
        //"nqxju"}, new string[]{
        //"cwxgg","uylnr","rchhwx","dxgntli"}, new string[]{
        //"gfcfsf"}, new string[]{
        //"ysgnao"}, new string[]{
        //"kvtpc"}, new string[]{
        //"raaxwq"}, new string[]{
        //"fewkfib","pyzwl","fbhnbdw","nqxju"}, new string[]{
        //"yffxaiy","piqgu","zkyiauj","xlufcc"}, new string[]{
        //"xeefzwg","mjgilv","metyk","yonxye"}, new string[]{
        //"gnitpo"}, new string[]{
        //"nlewmv"}, new string[]{
        //"gdhekde"}, new string[]{
        //"tyxfxu"}, new string[]{
        //"lmuwznh"}, new string[]{
        //"chwoyn"}, new string[]{
        //"mbmaqh"}, new string[]{
        //"xsulc"}, new string[]{
        //"hrbsamg","hhpib","qybyrm","agcpul","azrcn"}, new string[]{
        //"tpnvx","qggycuv","ctafsp","ourium"}, new string[]{
        //"uxgbnjk"}, new string[]{
        //"nqzvz"}, new string[]{
        //"kgfldlb","ajtjym","xnalv","hwevm"}, new string[]{
        //"rosop"}, new string[]{
        //"wuogj","rhnota","gdawyc"}, new string[]{
        //"hzxiv","zedqbr","ymfurx","xfapfj"}, new string[]{
        //"zbiypv","tlfbyq","idqaieo","adlvipk"}, new string[]{
        //"dcytmqp"}, new string[]{
        //"saykbn"}, new string[]{
        //"gpikz"}, new string[]{
        //"rqsjqrg","ctidma","kynrf","oxtckvl"}, new string[]{
        //"bzijz"}, new string[]{
        //"ozxpbo","bwqxk","bdgwdt","imzegu","dvjssd","cybhcko"}, new string[]{
        //"pkowhq","zfrsmm","tlskukk","fqkbscn","mlafk"}, new string[]{
        //"nylhp","heqvbi","sarwcau"}, new string[]{
        //"nwejb","epuiwg","mculw"}, new string[]{
        //"xfapfj"}, new string[]{
        //"sntovuq"}, new string[]{
        //"nehwool","knwlsi","zmzwttu","dqxwazb","ebxyi"}, new string[]{
        //"dvjssd","nbccggn","orydf"}, new string[]{
        //"oaantta"}, new string[]{
        //"vzayzaq"}, new string[]{
        //"zlubkqa"}, new string[]{
        //"xhkrx"}, new string[]{
        //"tkqke","zjevsui","emsjxz","hgywlzc"}, new string[]{
        //"nhhyvm"}, new string[]{
        //"pokjgkl"}, new string[]{
        //"dpvmn"}, new string[]{
        //"aokvbbi"}, new string[]{
        //"bzumy","yfkgike","nqata","zheomzg","hooxvp","glrrnl"}, new string[]{
        //"bpcrtwl"}, new string[]{
        //"irkhv"}, new string[]{
        //"tlskukk","ixoiuh","jdxth"}, new string[]{
        //"nbccggn"}, new string[]{
        //"svzqi"}, new string[]{
        //"tcmkx"}, new string[]{
        //"clhyd","ghmxos","zjxcrv"}, new string[]{
        //"zdlxv","eeuohnm","gzocll"}, new string[]{
        //"eyjdqm"}, new string[]{
        //"pmlim"}, new string[]{
        //"nbfbkao"}, new string[]{
        //"aeiktt"}, new string[]{
        //"rbgonm"}, new string[]{
        //"phmmydn"}, new string[]{
        //"agkgi","bibly","bttlx","kirowa"}, new string[]{
        //"zqjqic","humqvl","drfeinj","xxbwj"}, new string[]{
        //"aghou"}, new string[]{
        //"ysgotr","xxxxbnh","stfqd","ptamwey"}, new string[]{
        //"kmvkkze"}, new string[]{
        //"glhbvi"}, new string[]{
        //"baimp","yyyel","mgreg"}, new string[]{
        //"xcmre"}, new string[]{
        //"mhhbej"}, new string[]{
        //"gdawyc"}, new string[]{
        //"spdsz"}, new string[]{
        //"pupaehu","eolilw","czlmv","zlrvs","vrppl"}, new string[]{
        //"vmuqpj","aghou","aktswyh"}, new string[]{
        //"agcpul"}, new string[]{
        //"hhuhid"}, new string[]{
        //"pgkeahi"}, new string[]{
        //"nebwj"}, new string[]{
        //"glrrnl","zwake","gtezger"}, new string[]{
        //"dtqxiic"}, new string[]{
        //"pkbxhn"}, new string[]{
        //"qququw"}, new string[]{
        //"ilxgo","nwkxd","xsulc","weeriq"}, new string[]{
        //"ymonx"}, new string[]{
        //"nqata","ovgpa","cadrzx"}, new string[]{
        //"rahsrp"}, new string[]{
        //"wepvw"}, new string[]{
        //"kbefh"}, new string[]{
        //"cpess"}, new string[]{
        //"pqnkr","rnoaimc","pkditpt"}, new string[]{
        //"uqzoo","kitggwr","kywpr","saykbn","pxifep"}, new string[]{
        //"pgfomf"}, new string[]{
        //"vpcfu"}, new string[]{
        //"srqbs"}, new string[]{
        //"ixoiuh"}, new string[]{
        //"eozev"}, new string[]{
        //"qtqbdp"}, new string[]{
        //"zsjoz"}, new string[]{
        //"yflpz"}, new string[]{
        //"bpgafw"}, new string[]{
        //"imzegu","afpxssv","xdwzfh"}, new string[]{
        //"ygvwdmg"}, new string[]{
        //"vebli"}, new string[]{
        //"hshbiaq"}, new string[]{
        //"humqvl"}, new string[]{
        //"fozfiqf","ndqomrl","iwwngux","xaxuyg","cnbvz","wmfro"}, new string[]{
        //"iukfd","vcjavrw","mydixq"}, new string[]{
        //"eduxyw"}, new string[]{
        //"ygtbl"}, new string[]{
        //"fjmjc","zkhtua","furny","fewkfib"}, new string[]{
        //"csvxlo"}, new string[]{
        //"xzdhzoa"}, new string[]{
        //"avnosfl","zsraq","lzstd"}, new string[]{
        //"ptcby","dapjhx","hyzzwx","kpwfqfc","ivnufgs"}, new string[]{
        //"hvsywx","tvhftq","xuokqm"}, new string[]{
        //"gfsnb","gtixbu","micfuva"}, new string[]{
        //"qxkilb"}, new string[]{
        //"pkesm"}, new string[]{
        //"ndjjag"}, new string[]{
        //"vsffvp"}, new string[]{
        //"ieqgh","zkdwxd","weejuk","yptrqp"}, new string[]{
        //"jxevrgz"}, new string[]{
        //"mnjirpy"}, new string[]{
        //"hufrsq","cmouh","vbdycf","seicwz","pwdoio","bhwnch","ozxpbo"}, new string[]{
        //"tvhftq"}};
        //            int[] weights = { 78
        //,57
        //,98
        //,62
        //,64
        //,9
        //,359
        //,70
        //,33
        //,55
        //,78
        //,52
        //,88
        //,15
        //,33
        //,11
        //,68
        //,20
        //,29
        //,9
        //,164
        //,52
        //,104
        //,809
        //,63
        //,11
        //,191
        //,80
        //,99
        //,57
        //,66
        //,55
        //,66
        //,91
        //,123
        //,77
        //,16
        //,31
        //,67
        //,50
        //,91
        //,64
        //,49
        //,55
        //,93
        //,5
        //,83
        //,26
        //,94
        //,53
        //,73
        //,16
        //,25
        //,64
        //,36
        //,93
        //,10
        //,200
        //,391
        //,78
        //,176
        //,98
        //,57
        //,66
        //,16
        //,304
        //,256
        //,35
        //,60
        //,35
        //,33
        //,64
        //,59
        //,47
        //,72
        //,38
        //,55
        //,98
        //,92
        //,88
        //,13
        //,10
        //,29
        //,614
        //,133
        //,50
        //,36
        //,590
        //,23
        //,23
        //,37
        //,51
        //,117
        //,75
        //,58
        //,92
        //,1391
        //,11
        //,218
        //,86
        //,77
        //,57
        //,65
        //,9
        //,45
        //,93
        //,66
        //,5
        //,37
        //,13
        //,70
        //,92
        //,50
        //,17
        //,13
        //,92
        //,87
        //,43
        //,5
        //,27
        //,25
        //,80
        //,31
        //,91
        //,255
        //,411
        //,286
        //,50
        //,14
        //,264
        //,64
        //,163
        //,80
        //,52
        //,443
        //,267
        //,256
        //,394
        //,92
        //,56
        //,46
        //,35
        //,12
        //,47
        //,10
        //,66
        //,322
        //,85
        //,240
        //,86
        //,63
        //,226
        //,146
        //,19
        //,82
        //,97
        //,54
        //,931
        //,37
        //,87
        //,40
        //,91
        //,15
        //,245
        //,241
        //,37
        //,17
        //,54
        //,79
        //,91
        //,24
        //,10
        //,86
        //,92
        //,26
        //,276
        //,48
        //,389
        //,54
        //,16
        //,16
        //,5
        //,262
        //,217
        //,59
        //,38
        //,90
        //,31
        //,275
        //,57
        //,29
        //,64
        //,26
        //,43
        //,53
        //,221
        //,39
        //,184
        //,73
        //,48
        //,31
        //,37
        //,22
        //,6
        //,68
        //,37
        //,124
        //,91
        //,66
        //,199
        //,18042
        //,11
        //,14
        //,57
        //,228
        //,18
        //,10
        //,85
        //,135
        //,54
        //,297
        //,51
        //,66
        //,47
        //,79
        //,49
        //,138
        //,32
        //,118
        //,88
        //,89
        //,99
        //,1005
        //,12
        //,362
        //,147
        //,146
        //,65
        //,243
        //,213
        //,85
        //,70
        //,87
        //,20
        //,70
        //,20
        //,65
        //,79
        //,86
        //,44
        //,425
        //,39
        //,131
        //,53
        //,80
        //,202
        //,123
        //,49
        //,236
        //,76
        //,99
        //,61
        //,24
        //,65
        //,29
        //,705
        //,182
        //,50
        //,30
        //,25773
        //,23
        //,91
        //,241
        //,32
        //,86
        //,275
        //,80
        //,9
        //,410
        //,113
        //,13
        //,51
        //,97
        //,54
        //,79
        //,53
        //,54
        //,763
        //,43
        //,88
        //,199
        //,345
        //,45
        //,1390
        //,69
        //,36
        //,86
        //,72
        //,84
        //,90
        //,37
        //,27
        //,52
        //,104
        //,83
        //,93
        //,13
        //,276
        //,91
        //,70
        //,32
        //,317
        //,83
        //,60
        //,964
        //,51
        //,51
        //,87
        //,60
        //,13
        //,1022
        //,125
        //,92
        //,35
        //,348
        //,107
        //,32
        //,226
        //,10
        //,60
        //,87
        //,20
        //,16
        //,54
        //,50
        //,177
        //,86
        //,44
        //,86
        //,29
        //,164
        //,165
        //,34
        //,52
        //,90
        //,50
        //,61
        //,50
        //,43
        //,92
        //,70
        //,55
        //,83
        //,35
        //,6
        //,187
        //,90
        //,73
        //,24
        //,184
        //,64
        //,41
        //,255
        //,87
        //,60
        //,87
        //,202
        //,96
        //,41
        //,77
        //,86
        //,82
        //,49
        //,35
        //,5
        //,135
        //,71
        //,220
        //,344
        //,99
        //,33
        //,29
        //,91
        //,96
        //,45
        //,7
        //,60
        //,30
        //,68
        //,368
        //,54
        //,299
        //,40
        //,191
        //,77
        //,63
        //,85
        //,82
        //,27
        //,14
        //,83
        //,57
        //,313
        //,86
        //,150
        //,72
        //,280
        //,68
        //,55
        //,62
        //,54
        //,9
        //,220
        //,93
        //,1093
        //,27
        //,8
        //,70
        //,63
        //,91
        //,10
        //,57
        //,1446
        //,19
        //,66
        //,81
        //,51
        //,49
        //,71
        //,202
        //,77
        //,83
        //,1610
        //,31
        //,155
        //,122
        //,48
        //,47
        //,3465
        //,19
        //,47
        //,87
        //,83
        //,50
        //,5
        //,51
        //,29
        //,63
        //,87
        //,34
        //,81
        //,59
        //,81
        //,53
        //,56
        //,50
        //,102
        //,69
        //,31
        //,83
        //,84
        //,40
        //,66
        //,89
        //,83
        //,20
        //,202
        //,13
        //,16
        //,87
        //,65
        //,35
        //,572
        //,90
        //,50
        //,64
        //,56
        //,51
        //,143
        //,40
        //,373
        //,200
        //,112
        //,50
        //,314
        //,89
        //,60
        //,26
        //,55
        //,86
        //,60
        //,293
        //,68
        //,168
        //,220
        //,99
        //,88
        //,5
        //,257
        //,91
        //,265
        //,178
        //,15
        //,98
        //,64
        //,97
        //,2087
        //,1079
        //,85
        //,120
        //,36
        //,144
        //,98
        //,11
        //,2345
        //,83
        //,597
        //,92
        //,10
        //,18
        //,45
        //,31
        //,26
        //,360
        //,98
        //,86
        //,70
        //,15
        //,306
        //,65
        //,10
        //,54
        //,131
        //,9
        //,26
        //,46
        //,43
        //,92
        //,99
        //,49
        //,80
        //,178
        //,19
        //,46
        //,6
        //,117
        //,92
        //,14
        //,63
        //,43
        //,83
        //,98
        //,134
        //,92
        //,85
        //,54
        //,131
        //,83
        //,98
        //,75
        //,370
        //,91
        //,1021
        //,14
        //,94
        //,60
        //,84
        //,83
        //,8332
        //,10
        //,80
        //,33
        //,14
        //,24
        //,76
        //,91
        //,49
        //,15
        //,303
        //,10
        //,68
        //,17
        //,611
        //,94
        //,123
        //,43
        //,411
        //,76
        //,83
        //,894
        //,60
        //,177
        //,85
        //,55
        //,78
        //,147
        //,88
        //,79
        //,1300
        //,184
        //,391
        //,45
        //,119
        //,6
        //,76
        //,18
        //,185
        //,75
        //,228
        //,1760
        //,60
        //,40305
        //,10
        //,66
        //,42
        //,10
        //,38
        //,24
        //,79
        //,421
        //,54
        //,153
        //,13
        //,833
        //,241
        //,94
        //,280
        //,55
        //,50
        //,44
        //,78
        //,26
        //,69
        //,71
        //,9
        //,66
        //,120
        //,24
        //,23
        //,94
        //,54
        //,92
        //,99
        //,407
        //,15
        //,175
        //,11
        //,30
        //,98
        //,99
        //,15
        //,62
        //,93
        //,68
        //,73
        //,361
        //,280
        //,54
        //,35
        //,56
        //,224
        //,313
        //,70
        //,99
        //,57
        //,58
        //,123
        //,66
        //,17
        //,62
        //,38
        //,11
        //,53
        //,50
        //,24
        //,70
        //,29
        //,83
        //,94
        //,49
        //,204
        //,150
        //,37
        //,8
        //,158
        //,1785
        //,55
        //,44
        //,94
        //,48
        //,68
        //,32
        //,98
        //,13
        //,45
        //,1847
        //,8
        //,63
        //,168
        //,48
        //,43
        //,195
        //,116
        //,37
        //,32
        //,67
        //,73
        //,70
        //,23
        //,27213
        //,30
        //,92
        //,423
        //,98
        //,1683
        //,169
        //,6
        //,22
        //,73
        //,48
        //,98
        //,73
        //,33
        //,79
        //,64
        //,84
        //,87
        //,63
        //,369
        //,52
        //,42
        //,15
        //,59
        //,68
        //,102
        //,48
        //,48
        //,6
        //,135
        //,54
        //,93
        //,63
        //,98
        //,50
        //,51
        //,40
        //,8
        //,221
        //,59
        //,1115
        //,247
        //,91
        //,93
        //,58
        //,47
        //,415
        //,36
        //,31
        //,220
        //,93
        //,236
        //,47
        //,47
        //,93
        //,65
        //,97
        //,11
        //,306
        //,246
        //,71
        //,32
        //,99
        //,22
        //,31
        //,41
        //,52
        //,86
        //,13
        //,6
        //,77
        //,52
        //,240
        //,78
        //,260
        //,22
        //,1033
        //,158
        //,93
        //,173
        //,37
        //,98
        //,226
        //,53
        //,1507
        //,47
        //,97
        //,486
        //,89
        //,23
        //,51
        //,30
        //,189
        //,54
        //,160
        //,32
        //,5
        //,41
        //,6
        //,85
        //,52
        //,371
        //,27
        //,372
        //,64
        //,133
        //,106
        //,56
        //,11700
        //,250
        //,90
        //,232
        //,42
        //,23
        //,98
        //,252
        //,70
        //,411
        //,79
        //,105
        //,88
        //,914
        //,31
        //,84
        //,582
        //,22
        //,33
        //,320
        //,19
        //,38
        //,68
        //,42
        //,37
        //,58
        //,53
        //,60
        //,97
        //,11
        //,107
        //,37
        //,26
        //,1825
        //,86
        //,30
        //,44
        //,299
        //,1167
        //,274
        //,374
        //,194
        //,68
        //,49
        //,98
        //,1346
        //,50
        //,38
        //,31
        //,83
        //,21
        //,52
        //,90
        //,7
        //,94
        //,10
        //,81
        //,18
        //,188
        //,33
        //,15
        //,8
        //,230
        //,50
        //,6251
        //,87
        //,69
        //,70
        //,22
        //,41
        //,53
        //,29
        //,98
        //,33
        //,418
        //,41
        //,26
        //,49
        //,52
        //,79
        //,38
        //,5
        //,80
        //,81
        //,63
        //,81
        //,296
        //,41
        //,31
        //,16
        //,93
        //,720
        //,63
        //,97
        //,27
        //,6
        //,4571
        //,180
        //,83
        //,51
        //,59
        //,70
        //,244
        //,48
        //,30
        //,43
        //,92
        //,43
        //,126
        //,38
        //,8531
        //,26
        //,41
        //,86
        //,344
        //,90
        //,232
        //,56
        //,76
        //,32
        //,63
        //,965
        //,1014
        //,1740
        //,50
        //,38
        //,88
        //,9
        //,7
        //,18
        //,188
        //,19
        //,16
        //,284
        //,90
        //,13
        //,378
        //,294
        //,411
        //,176
        //,1040
        //,93
        //,91
        //,41
        //,1937
        //,66
        //,137
        //,1187
        //,171
        //,313
        //,26
        //,37
        //,78
        //,98
        //,14
        //,17
        //,27
        //,51
        //,1073
        //,45
        //,8
        //,99
        //,40
        //,1522
        //,24
        //,92
        //,1464
        //,91
        //,47
        //,51
        //,220
        //,287
        //,78
        //,78
        //,50
        //,44
        //,9
        //,78
        //,156
        //,1602
        //,51
        //,954
        //,55
        //,64
        //,158
        //,67
        //,36
        //,37
        //,68
        //,99
        //,160
        //,98
        //,71
        //,18
        //,94
        //,52
        //,21
        //,62
        //,73
        //,237
        //,56
        //,122
        //,70
        //,69
        //,83
        //,98
        //,186
        //,47
        //,12
        //,54
        //,221
        //,14
        //,63
        //,8
        //,73
        //,40
        //,70
        //,190
        //,91
        //,73
        //,91
        //,222
        //,52
        //,291
        //,79
        //,89
        //,3192
        //,236
        //,45
        //,87
        //,71
        //,170
        //,71
        //,20
        //,92
        //,59
        //,5
        //,247
        //,60
        //,24
        //,3110
        //,35};
        //part 1
        //var x = 0;
        //for(var i = 0;i<input.Length;i++)
        //{
        //    if(input[i].Length == 1)
        //    {
        //        input[i] = null;
        //    }
        //    else
        //    {
        //        valid[x] = input[i];
        //        x++;
        //    }
        //}
        //Console.WriteLine(x);
        //Console.WriteLine(checkBottom(valid));
        //Console.ReadKey();
        //part 2

        //        string[] aapssr = { "twimhx", "wfdiqkg", "guuri", "qwada", "mwsivlf" };
        //string[] qwada = {"wfkcsb", "qlboef", "pkowhq"};
        //string[] pkowhq = {"zfrsmm", "tlskukk", "fqkbscn", "mlafk");
        //        for(var i = 0;i<aapssr.Length;i++)
        //        {
        //            Console.WriteLine(checkWeight(input,weights,aapssr[i]));
        //        }
        //for(var i = 0;i<qwada.Length;i++)
        //        {
        //            Console.WriteLine(checkWeight(input,weights,qwada[i]));
        //        }
        //for(var i = 0;i<pkowhq.Length;i++)
        //        {
        //            Console.WriteLine(checkWeight(input,weights,pkowhq[i]));
        //        }
        //        for(var i = 0;i<input.Length;i++)
        //        {
        //            if(input[i][0] == "tlskukk")
        //            {
        //                Console.WriteLine(weights[i]);
        //            }
        //        }
        //        Console.ReadKey();
        //}
        //part 1
        //internal static string checkBottom(string[][] valid)
        //{
        //    for(var i =0;i<valid.Length;i++)
        //    {
        //        var z = 0;
        //        for (var x = 0; x < valid.Length; x++)
        //        {
        //            for (var j = 1; j < valid[x].Length; j++)
        //            {
        //                if (valid[i][0] == valid[x][j])
        //                {
        //                    z++;
        //                }
        //            }
        //        }

        //        if (z == 0)
        //        {
        //            Console.WriteLine(valid[i][0]);
        //            return valid[i][0];
        //        }
        //    }
        //    return "";
        //}
        //part 2
        //internal static int checkWeight(string[][] input,int[] weights,string tower)
        //{
        //    var x = 0;
        //    for (var i = 0; i < input.Length; i++)
        //    {
        //        if (tower == input[i][0])
        //        {

        //            x += weights[i];
        //            if (input[i].Length > 1)
        //                for (var j = 1; j < input[i].Length; j++)
        //                {
        //                    x += checkWeight(input, weights, input[i][j]);
        //                }

        //        }
        //        if (tower == "qwada")
        //        {
        //            Console.WriteLine("Tower: {0} Weight: {1}", input[i][0], weights[i]);
        //        }
        //    }
        //    return x;
        //}
    } 
}
