using System.Globalization;

public class Scripture
{
    
    private Reference _reference;
    private List<Word> _words= new List <Word>();
    private  Random rand = new Random();
    

    public Scripture(Reference reference, string text )
   
    {
       _reference = reference;
       _words = new List<Word>();
       foreach (string t in text.Split(" "))
        {
            _words.Add(new Word(t));
        }
        
    }
    public void HideRandomWords(int numberToHide)
    {
       List<Word> visible = _words.Where(w => !w.IsHidden()).ToList();
        
        if(visible.Count==0)
            return;

        for (int i =0; i< numberToHide && visible.Count>0; i++);
        {
            int index = rand.Next(visible.Count);
            visible[index].Hide();
            visible.RemoveAt(index);
        }    
             
     }    
    public string GetDisplayText()
    {
       List<string> result = new List<string>();
       foreach(Word w in _words)
        {
            result.Add(w.GetDisplayText());
        }
        return string.Join(" ",result);
    }
     public bool IsCompletelyHidden()
        {   
            foreach(Word w in _words)
            {
                if (!w.IsHidden())
                {
                    return false;
                }   
            }
              return true; 
            
        }   
}