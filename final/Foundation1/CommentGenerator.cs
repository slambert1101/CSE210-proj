using System;

class CommentGenerator
{
    private List<string> _people;
    private List<string> _comments;

    public CommentGenerator()
    {
        _people = [
            "Bob", "Jim", "Carly", "Chuck", "Donald Duck", "Jenna", "Meg", "Carlos", "Richard"
        ];

        _comments = [
            "This video rocks!", "Two thumbs up!", "It doesn't make any sense.", "This is a cinematic masterpeice.", "LOL", "Thank you. This video was really helpful.", "I ate a bug", "I don't know whether to laugh or cry"
        ];
    }

    public Comment GenerateComment()
    {
        Random random = new Random();
        Comment comment = new Comment(_people[random.Next(_people.Count())], _comments[random.Next(_comments.Count())]);
        return comment;
    }
}