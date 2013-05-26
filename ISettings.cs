namespace TweetdeckSucks
{
  public interface ISettings {
    void Save();

    void Cancel();

    string GetString(string key);

    bool GetBool(string key);

    int GetInt(string key);

    float GetFloat(string key);

    bool Contains(string key);

    void SetString(string key, string value);

    void SetBool(string key, bool value);

    void SetInt(string key, int value);

    void SetFloat(string key, float value);

    void Delete(string key);
  }
}