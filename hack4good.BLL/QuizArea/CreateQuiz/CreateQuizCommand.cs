﻿using MediatR;

namespace hack4good.BLL.QuizArea.CreateQuiz;

public class CreateQuizCommand : IRequest<Guid>
{
    public string Title { get; set; }

    public string Description { get; set; }

    public ICollection<QuizStepDetail> Steps { get; set; }
}