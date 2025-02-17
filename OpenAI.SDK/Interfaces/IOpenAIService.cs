﻿namespace OpenAI.GPT3.Interfaces;

public interface IOpenAIService
{
    /// <summary>
    ///     List and describe the various models available in the API. You can refer to the
    ///     <a href="https://beta.openai.com/docs/models">Models</a> documentation to understand what models are available and
    ///     the differences between them.
    /// </summary>
    public IModelService Models { get; }

    /// <summary>
    ///     Given a prompt, the model will return one or more predicted completions, and can also return the probabilities of
    ///     alternative tokens at each position.
    /// </summary>
    public ICompletionService Completions { get; }

    /// <summary>
    ///     Creates an embedding vector representing the input text.
    /// </summary>
    public IEmbeddingService Embeddings { get; }

    /// <summary>
    ///     Files are used to upload documents that can be used across features like <see cref="FineTunes" />
    /// </summary>
    public IFileService Files { get; }

    public IFineTuneService FineTunes { get; }

    public IModerationService Moderation { get; }

    /// <summary>
    ///     Given a prompt and/or an input image, the model will generate a new image.
    /// </summary>
    public IImageService Image { get; }

    /// <summary>
    ///     Creates a new edit for the provided input, instruction, and parameters
    /// </summary>
    public IEditService Edit { get; }


    /// <summary>
    ///     Set default model
    /// </summary>
    /// <param name="modelId"></param>
    void SetDefaultModelId(string modelId);
}