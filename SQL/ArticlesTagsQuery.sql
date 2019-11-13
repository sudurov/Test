SELECT 
	art.Topic
	, SUBSTRING(
        (
			SELECT 
				', ' + tg.Text
			FROM ArticlesTags art_tg
			inner join Tags tg on art_tg.TagID = tg.ID
				WHERE art_tg.ArticleID = art.ID
			FOR XML PATH ('')
		), 3, 1000) Tags
from Articles art