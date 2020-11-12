using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3_SameSameGame
{
    public partial class FrmMain : Form
    {
        int[,] m_nBlock;
        int[] m_nSel;             // 선택된 블럭(인접한 같은 모양의 블럭) 저장
        bool[,] m_bVisit;    // 방문했는지 표시
        int m_nSameCnt;                         // 인접한 같은 모양의 개수

        int maxY { get; set; }
        int maxX { get; set; }

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            maxX = 20;
            maxY = 10;
            m_nBlock = new int[maxX, maxY];
            m_nSel = new int[maxX * maxY];
            m_bVisit = new bool[maxX, maxY];

        }

        private void FindSameBlock(int nX, int nY)
        {
            // 위로찾기
            if(nY<0)
            {
                if((m_nBlock[nX,nY-1]==m_nPointBlock)&&m_bVisit[nX,nY-1]==false)
                {
                    m_nSel[m_nSameCnt] = (nY - 1) * maxX + nX; // x,y값을 index로변환
                    m_nSameCnt += 1;

                    m_bVisit[nX, nY - 1] = true;
                    FindSameBlock(nX, nY -1);
                }
            }
            if(nY<9)
            {
                if ((m_nBlock[nX, nY+1] == m_nPointBlock) && m_bVisit[nX, nY + 1] == false)
                {
                    m_nSel[m_nSameCnt] = (nY + 1) * maxX + nX; // x,y값을 index로변환
                    m_nSameCnt += 1;

                    m_bVisit[nX, nY + 1] = true;
                    FindSameBlock(nX, nY + 1);
                }
            }
            if (nX > 0)
            {
                if ((m_nBlock[nX-1, nY] == m_nPointBlock) && m_bVisit[nX-1, nY] == false)
                {
                    m_nSel[m_nSameCnt] = nY* maxX + (nX-1); // x,y값을 index로변환
                    m_nSameCnt += 1;

                    m_bVisit[nX-1, nY] = true;
                    FindSameBlock(nX-1, nY);
                }
            }
            if (nX < maxX-1)
            {
                if ((m_nBlock[nX + 1, nY] == m_nPointBlock) && m_bVisit[nX + 1, nY] == false)
                {
                    m_nSel[m_nSameCnt] = nY * 20 + (nX + 1); // x,y값을 index로변환
                    m_nSameCnt += 1;

                    m_bVisit[nX + 1, nY] = true;
                    FindSameBlock(nX + 1, nY);
                }
            }
        }
        private void MoveY()
        {
            int i, j;
            int nIndex;
            int nX, nY;
            bool[] bX = new bool[maxX];

            // 빈칸을 정리
            for(i=0;i<m_nSameCnt;i++)
            {
                nIndex = m_nSel[i];

                nX = nIndex % maxX;
                nY = (int)(nIndex / 20);

                int nEmptyY;
                nEmptyY = -1;

                // 아래에서 위쪽으로 빈칸을 찾는다.
                // 찾은 빈칸의 위에도 계속 빈칸이면 무시한다.
                for(j=9;j>0;j--)
                {
                    if(m_nBlock[nX,j]==-1&&m_nBlock[nX,j-1]!=-1)
                    {
                        if(m_nBlock[nX,j]==-1 && m_nBlock[nX, j-1]!=-1)
                        {
                            nEmptyY = j;
                            break;
                        }
                    }
                }

                // 빈칸을 찾은 경우
                if(nEmptyY !=-1)
                {
                    //그림을 한 칸씩 아래로 내려준다.
                    for(j=nEmptyY;j>0;j--)
                    {
                        m_nBlock[nX, j] = m_nBlock[nX, j - 1];
                    }
                    m_nBlock[nX, 0] = -1;
                }
            }
            PictureBox pic;

            // 정리된 결과를 화면에 출력
            for(i=0;i<m_nSameCnt;i++)
            {
                nIndex = m_nSel[i] % maxX;
                nX = nIndex % maxX;
                nY = (int)(nIndex / maxX);

                if(bX[nX]==false)
                {
                    bX[nX] = true;

                    // -1이 저장된 컨트롤의 Visible을 false, 아닌것을 True
                    for(j=9;j>=0;j--)
                    {
                        if(m_nBlock[nX,j]==-1)
                        {
                            //그림을 지우고
                            panMain.Controls[j * maxX + nX].Visible = false;
                        }
                        else
                        {
                            if(panMain.Controls[j*maxX+nX].Visible == false)
                            {
                                // 그림을 지우고
                                panMain.Controls[j * maxX + nX].Visible = true;
                            }
                            else // 그림을 다시 채운다.
                            {
                                if (panMain.Controls[j * maxX + nX].Visible == false)
                                    panMain.Controls[j * maxX + nX].Visible = true;
                                pic = (PictureBox)panMain.Controls[j * maxX + nX];
                                pic.Image = imglstBlock.Images[m_nBlock[nX, j]];

                            }
                        }
                    }
                }
            }
        }

        private void MoveX()
        {
            int i, j;
            int nIndex;
            int nX, nY;
            bool bY;
            int nMinX;

            nMinX = maxX-1;
            bY = false;

            for(i=0;i<m_nSameCnt;i++)
            {
                nIndex = m_nSel[i];

                nX = nIndex % maxX;
                nY = (int)(nIndex / maxX);

                // 맨 아래칸이 삭제된 경우
                if(nY==maxY-1)
                {
                    int nEmptyX;
                    nEmptyX = -1;
                    for(j=0;j<maxX-1;j++)
                    {
                        if(m_nBlock[j,9] == -1 && m_nBlock[j+1,9]!=-1)
                        {
                            nEmptyX = j;
                            if(nMinX > nEmptyX)
                            {
                                nMinX = nEmptyX;
                                break;
                            }
                        }
                    }
                    // 오른쪽의 블럭을 옮긴다.
                    if(nEmptyX != -1)
                    {
                        bY = true;
                        int k;
                        for(j=nEmptyX;j<maxX;j++)
                        {
                            for(k=0;k<maxY;k++)
                            {
                                if(j==maxX-1)
                                {
                                    m_nBlock[j, k] = -1;
                                }
                                else
                                {
                                    m_nBlock[j, k] = m_nBlock[j + 1, k];
                                }
                            }
                        }
                    }
                }
            }

            // 빈칸이 없음 블럭을 옮길 필요가 없다
            if (bY == false) return;

            PictureBox pic;
            for (i = nMinX; i < maxX; i++)
            {
                for (j = 0; j < maxY; j++)
                {
                    nIndex = i + j * maxX;
                    pic = (PictureBox)panMain.Controls[nIndex];
                    if (m_nBlock[i, j] == -1) // 빈칸일 경우 visible을 flase로
                    {
                        if (pic.Visible)
                            pic.Visible = false;
                    }
                    else // 빈칸이 아닐 경우 맞는 그림을 보여준다.
                    {
                        if (pic.Visible == false)
                        {
                            pic.Visible = true;
                        }
                        pic.Image = imglstBlock.Images[m_nBlock[i, j]];
                    }
                }
            }
        }
    }
}
