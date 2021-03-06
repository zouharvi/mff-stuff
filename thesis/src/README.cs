Šablona pro sazbu bakalářské práce na MFF UK v LaTeXu

Autoři:

	Martin Mareš <mj@ucw.cz> -- správce šablony
	Arnošt Komárek <komarek@karlin.mff.cuni.cz>
	Michal Kulich <kulich@karlin.mff.cuni.cz>

Tento balík souborů je povoleno libovolně šířit, používat a upravovat.
Pokud máte jakékoliv připomínky nebo návrhy na vylepšení, dejte prosím vědět.
--------------------------------------------------------------------------------

Šablona existuje ve dvou verzích -- české (adresář cs) a anglické (en).

Povinné náležitosti úpravy bakalářských prací jsou dány směrnicemi děkana
č. 4/2019, 1/2015 a 7/2016 a opatřením rektora č. 72/2017. Mimo to existují
ještě další doporučení -- ta najdete v souboru vzor.pdf. Tento formát pro LaTeX
se jimi řídí a snaží se důležité věci připomínat komentáři. Přesto si ale celá
pravidla přečtěte.

Pokud LaTeX ještě neznáte, na webu naleznete mnoho úvodních textů.
Nám se nejvíce osvědčil http://en.wikibooks.org/wiki/LaTeX.

Základní nastavení sazby naleznete v souboru prace.tex, ten se také
odkazuje na ostatní soubory s jednotlivými kapitolami práce. Pečlivě
si hlavní soubor přečtěte a doplňte všechny chybějící údaje. Také je
doplňte do metadatového souboru prace.xmpdata.

Česká verze obsahuje komentáře a ukázkové kapitoly s popisem doporučené
úpravy a různými radami pro sazbu v TeXu. Anglická verze má zatím pouze
komentáře.

Elektronická podoba práce, kterou odevzdáváte do SISu, musí být povinně
ve formátu PDF/A-1a nebo -2u. Tato šablona vytváří PDF/A-2u pomocí balíčku
pdfx (https://www.ctan.org/tex-archive/macros/latex/contrib/pdfx). Pozor,
v mnoha instalacích TeXu je tento balíček buď zastaralý nebo nefunkční,
takže si ho raději stáhněte samostatně a rozbalte do adresáře tex/pdfx/.

Další instrukce k přípravě PDF/A naleznete v ukázkových kapitolách
a na http://mj.ucw.cz/vyuka/bc/pdfaq.html.

Upozorňujeme, že MikTeX pod Windows má problémy s některými (obzvláště
matematickými) fonty a vytváří pak nekorektní PDF/A. Doporučujeme místo
něj použít distribuci TeXlive.

Pokud pracujete na Unixovém systému, může se vám hodit ukázkový Makefile --
stačí spustit program "make" a ten už se postará o přeložení všech souborů
TeXem.

TeX také můžete spouštět ručně. V tom případě je potřeba překládat pdfTeXem
a spustit bibTeX na vygenerování bibliografie. (Ideálně takto: pdflatex, bibtex,
a pak 2x pdflatex pro dopočítání referencí. Případně využít latexmk.)

Další materiály o psaní bakalářských prací a odborných textů vůbec najdete
na http://mj.ucw.cz/vyuka/bc/. Tamtéž se nachází aktuální vývojová verze této
šablony.
