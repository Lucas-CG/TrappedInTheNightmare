  <div>
  {% for post in site.posts %}
      <small>Publicado dia {{ post.date | date: "%-m/%-d/%y" }} em {{ post.categories | join: ', ' }}</small>
      <h2><a href="{{ site.baseurl }}{{ post.url }}">{{ post.title }}</a></h2>
      <p>{{ post.excerpt }}</p>
  {% endfor %}
  </div>
